using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.SmartFormat;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;
using UnityEngine.SceneManagement;

namespace HoshinoLabs.Localization {
    internal sealed class LocalizationPreBuilder : IProcessSceneWithReport {
        public int callbackOrder => -5000;

        public void OnProcessScene(Scene scene, BuildReport report) {
            LocalizationHelper.AvailableLocales = BuildAvailableLocales();
            LocalizationHelper.ReferenceGroupIds = BuildGroupIds();
            LocalizationHelper.ReferenceVariableIds = BuildReferenceVariableIds();
            var stringEntries = CollectAllStringEntry();
            var assetEntries = CollectAllAssetEntry();
            LocalizationHelper.ReferenceStringIds = BuildReferenceStringIds(stringEntries);
            LocalizationHelper.ReferenceAssetIds = BuildReferenceAssetIds(assetEntries);
            LocalizationHelper.StringDatabase = BuildStringDatabase(stringEntries);
            LocalizationHelper.AssetDatabase = BuildAssetDatabase();
        }

        static Locale[] BuildAvailableLocales() {
            return LocalizationSettings.AvailableLocales.Locales
                .Select(x => new Locale(x.Identifier.CultureInfo.EnglishName, x.Identifier.Code, x.Identifier.CultureInfo))
                .ToArray();
        }

        static StringTable[] CollectAllStringTable(Locale locale) {
            return LocalizationEditorSettings.GetStringTableCollections()
                .Select(x => x.StringTables.Where(x => x.LocaleIdentifier.Code == locale.Code).FirstOrDefault())
                .Where(x => x)
                .ToArray();
        }

        static AssetTable[] CollectAllAssetTable(Locale locale) {
            return LocalizationEditorSettings.GetAssetTableCollections()
                .Select(x => x.AssetTables.Where(x => x.LocaleIdentifier.Code == locale.Code).FirstOrDefault())
                .Where(x => x)
                .ToArray();
        }

        static IEnumerable<TableEntry> CollectAllStringEntry(StringTable table) {
            return table.Select(x => new TableEntry(
                tableId: table.TableCollectionName,
                entryId: x.Key.ToString(),
                name: x.Value.Key
            ));
        }

        static TableEntry CollectAllStringEntry(LocalizeStringEvent localizeString) {
            var localized = localizeString.StringReference;
            if (localized.TableReference.ReferenceType != TableReference.Type.Guid) {
                return null;
            }
            if (localized.TableEntryReference.ReferenceType != TableEntryReference.Type.Id) {
                return null;
            }
            return new TableEntry(
                tableId: localized.TableReference.TableCollectionName,
                entryId: localized.TableEntryReference.KeyId.ToString(),
                name: localized.TableEntryReference.Key
            );
        }

        static TableEntry[] CollectAllStringEntry() {
            return new [] {
                LocalizationHelper.AvailableLocales
                    .Select(x => CollectAllStringTable(x))
                    .SelectMany(x => x)
                    .Select(table => CollectAllStringEntry(table))
                    .SelectMany(x => x),
                LocalizationHelper.ReferenceGroupIds
                    .Keys
                    .Select(x => {
                        switch (x) {
                            case LocalizeStringEvent localizeString: {
                                    return CollectAllStringEntry(localizeString);
                                }
                            default: {
                                    return null;
                                }
                        }
                    })
                    .Where(x => x != null),
            }
            .SelectMany(x => x)
            .GroupBy(x => (x.TableId, x.EntryId))
            .Select(x => x.First())
            .ToArray();
        }

        static IEnumerable<TableEntry> CollectAllAssetEntry(AssetTable table) {
            return table.Select(x => new TableEntry(
                tableId: table.TableCollectionName,
                entryId: x.Key.ToString(),
                name: x.Value.Key
            ));
        }

        static TableEntry CollectAllAssetEntry<T, U, V>(LocalizedAssetEvent<T, U, V> localizeAsset)
            where T : UnityEngine.Object
            where U : LocalizedAsset<T>, new()
            where V : UnityEvent<T>, new() {
            var localized = localizeAsset.AssetReference;
            if (localized.TableReference.ReferenceType != TableReference.Type.Guid) {
                return null;
            }
            if (localized.TableEntryReference.ReferenceType != TableEntryReference.Type.Id) {
                return null;
            }
            return new TableEntry(
                tableId: localized.TableReference.TableCollectionName,
                entryId: localized.TableEntryReference.KeyId.ToString(),
                name: localized.TableEntryReference.Key
            );
        }

        static TableEntry[] CollectAllAssetEntry() {
            return new[] {
                LocalizationHelper.AvailableLocales
                    .Select(x => CollectAllAssetTable(x))
                    .SelectMany(x => x)
                    .Select(table => CollectAllAssetEntry(table))
                    .SelectMany(x => x),
                LocalizationHelper.ReferenceGroupIds
                    .Keys
                    .Select(x => {
                        switch (x) {
                            case LocalizeAudioClipEvent localizeAudioClip: {
                                    return CollectAllAssetEntry(localizeAudioClip);
                                }
                            case LocalizeTextureEvent localizeTexture: {
                                    return CollectAllAssetEntry(localizeTexture);
                                }
                            case LocalizeSpriteEvent localizeSprite: {
                                    return CollectAllAssetEntry(localizeSprite);
                                }
                            default: {
                                    return null;
                                }
                        }
                    })
                    .Where(x => x != null),
            }
            .SelectMany(x => x)
            .GroupBy(x => (x.TableId, x.EntryId))
            .Select(x => x.First())
            .ToArray();
        }

        static Dictionary<(string tableId, string entryId), int> BuildReferenceStringIds(TableEntry[] stringEntries) {
            return stringEntries
                .Select((v, i) => (v, i))
                .ToDictionary(x => (x.v.TableId, x.v.EntryId), x => x.i);
        }

        static Dictionary<(string tableId, string entryId), int> BuildReferenceAssetIds(TableEntry[] assetEntries) {
            return assetEntries
                .Select((v, i) => (v, i))
                .ToDictionary(x => (x.v.TableId, x.v.EntryId), x => x.i);
        }

        static Dictionary<LocalizedMonoBehaviour, int> BuildGroupIds() {
            return new LocalizedMonoBehaviour[][] {
                    GameObject.FindObjectsOfType<LocalizeAudioClipEvent>(true),
                    GameObject.FindObjectsOfType<LocalizeStringEvent>(true),
                    GameObject.FindObjectsOfType<LocalizeTextureEvent>(true),
                    GameObject.FindObjectsOfType<LocalizeSpriteEvent>(true),
                }
                .SelectMany(x => x)
                .Select((v, i) => (v, i))
                .ToDictionary(x => x.v, x => x.i);
        }

        static Dictionary<(LocalizedMonoBehaviour group, int index), int> BuildReferenceVariableIds() {
            return LocalizationHelper.ReferenceGroupIds
                .Keys
                .OfType<LocalizeStringEvent>()
                .Where(x => x != null)
                .Select(x => {
                    return x.StringReference.Values
                        .Where(x => {
                            switch (x) {
                                case BoolVariable:
                                case SByteVariable:
                                case ByteVariable:
                                case ShortVariable:
                                case UShortVariable:
                                case IntVariable:
                                case UIntVariable:
                                case LongVariable:
                                case ULongVariable:
                                case StringVariable:
                                case FloatVariable:
                                case DoubleVariable:
                                case ObjectVariable:
                                case LocalizedString:
                                //case CurrentTime:
                                //case DateTimeVariable:
                                case UdonVariable: {
                                        return true;
                                    }
                                default: {
                                        return false;
                                    }
                            }
                        })
                        .Select((_, i) => ((LocalizedMonoBehaviour)x, i));
                })
                .SelectMany(x => x)
                .Select((v, i) => (v, i))
                .ToDictionary(x => x.v, x => x.i);
        }

        static StringTableEntryData BuildStringTableEntryData(StringTableEntry entry) {
            var value = entry.Value;
            var smart = entry.IsSmart;
            return new StringTableEntryData(value, smart);
        }

        static StringTableEntryData BuildStringTableEntryData(Locale locale, int assetId, TableEntry[] stringEntries) {
            var args = new Dictionary<string, object>() {
                ["key"] = stringEntries[assetId].Name ?? string.Empty,
                ["keyId"] = stringEntries[assetId].EntryId,
                ["table"] = new Dictionary<string, object> {
                    ["TableCollectionName"] = stringEntries[assetId].TableId,
                },
                ["locale"] = locale,
            };
            var value = LocalizationSettings.StringDatabase.NoTranslationFoundMessage.FormatSmart(args);
            return new StringTableEntryData(value, false);
        }

        static StringTableEntryData[][] BuildStringDatabase(TableEntry[] stringEntries) {
            return LocalizationHelper.AvailableLocales.Select(locale => {
                var database = new StringTableEntryData[LocalizationHelper.ReferenceStringIds.Count];
                foreach (var table in CollectAllStringTable(locale)) {
                    var tableId = table.TableCollectionName;
                    foreach (var entry in table) {
                        var entryId = entry.Key.ToString();
                        var assetId = LocalizationHelper.ReferenceStringIds[(tableId, entryId)];
                        database[assetId] = BuildStringTableEntryData(entry.Value);
                    }
                }
                return database
                    .Select((v, i) => v == null ? BuildStringTableEntryData(locale, i, stringEntries) : v)
                    .ToArray();
            }).ToArray();
        }

        static AssetTableEntryData BuildAssetTableEntryData(AssetTable table, AssetTableEntry entry) {
            var assetType = LocalizationEditorSettings.GetAssetTableCollection(table.SharedData.TableCollectionNameGuid).GetEntryAssetType(entry.Key);
            var assetPath = UnityEditor.AssetDatabase.GUIDToAssetPath(entry.Guid);
            var value = UnityEditor.AssetDatabase.LoadAssetAtPath(assetPath, assetType);
            return new AssetTableEntryData(value);
        }

        static AssetTableEntryData[][] BuildAssetDatabase() {
            return LocalizationHelper.AvailableLocales.Select(locale => {
                var database = new AssetTableEntryData[LocalizationHelper.ReferenceAssetIds.Count];
                foreach (var table in CollectAllAssetTable(locale)) {
                    var tableId = table.TableCollectionName;
                    foreach (var entry in table) {
                        var entryId = entry.Key.ToString();
                        var assetId = LocalizationHelper.ReferenceAssetIds[(tableId, entryId)];
                        database[assetId] = BuildAssetTableEntryData(table, entry.Value);
                    }
                }
                return database;
            }).ToArray();
        }
    }
}

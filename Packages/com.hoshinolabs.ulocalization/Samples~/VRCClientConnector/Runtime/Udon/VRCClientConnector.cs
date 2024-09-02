﻿using HoshinoLabs.ULocalization.Udon;
using HoshinoLabs.Sardinject;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace HoshinoLabs.ULocalization.Samples.Udon {
    [AddComponentMenu("")]
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public sealed class VRCClientConnector : UdonSharpBehaviour {
        [Inject, SerializeField, HideInInspector]
        ILocalization localization;

        string prevLanguage = null;

        private void Start() {
            prevLanguage = localization.SelectedLocale;
        }

        private void Update() {
            var language = VRCPlayerApi.GetCurrentLanguage();
            if (prevLanguage != language) {
                if (language != null) {
                    localization.SelectedLocale = language;
                }

                prevLanguage = language;
            }
        }
    }
}

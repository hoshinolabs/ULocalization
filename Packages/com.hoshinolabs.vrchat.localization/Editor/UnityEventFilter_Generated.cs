using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoshinoLabs.Localization {
	internal static partial class UnityEventFilter {
		static Dictionary<Type, HashSet<string>> allowedUnityEventTargetTypes = new Dictionary<Type, HashSet<string>>() {
			[typeof(global::UnityEngine.AI.NavMeshAgent)] = new HashSet<string> {
				"get_name",
				"set_name",
				"CompleteOffMeshLink",
				"ResetPath",
			},
			[typeof(global::UnityEngine.AI.NavMeshObstacle)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AI.OffMeshLink)] = new HashSet<string> {
				"get_name",
				"set_name",
				"UpdatePositions",
			},
			[typeof(global::UnityEngine.Animator)] = new HashSet<string> {
				"get_name",
				"set_name",
				"SetTrigger",
				"ResetTrigger",
				"InterruptMatchTarget",
				"WriteDefaultValues",
				"PlayInFixedTime",
				"Play",
				"StartPlayback",
				"StopPlayback",
				"StopRecording",
				"Rebind",
				"ApplyBuiltinRootMotion",
			},
			[typeof(global::UnityEngine.Animations.AimConstraint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Animations.PositionConstraint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Animations.RotationConstraint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Animations.ScaleConstraint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Animations.LookAtConstraint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Animations.ParentConstraint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AudioSource)] = new HashSet<string> {
				"get_clip",
				"set_clip",
				"get_name",
				"set_name",
				"Play",
				"PlayOneShot",
				"Stop",
				"Pause",
				"UnPause",
			},
			[typeof(global::UnityEngine.AudioLowPassFilter)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AudioHighPassFilter)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AudioReverbFilter)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AudioListener)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.AudioReverbZone)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AudioDistortionFilter)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AudioEchoFilter)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AudioChorusFilter)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Cloth)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Camera)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Reset",
				"ResetTransparencySortSettings",
				"ResetAspect",
				"ResetCullingMatrix",
				"ResetReplacementShader",
				"ResetWorldToCameraMatrix",
				"ResetProjectionMatrix",
				"ResetStereoProjectionMatrices",
				"ResetStereoViewMatrices",
				"Render",
				"RenderDontRestore",
			},
			[typeof(global::UnityEngine.FlareLayer)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.ReflectionProbe)] = new HashSet<string> {
				"get_bakedTexture",
				"set_bakedTexture",
				"get_customBakedTexture",
				"set_customBakedTexture",
				"get_texture",
				"get_name",
				"set_name",
				"Reset",
			},
			[typeof(global::UnityEngine.BillboardRenderer)] = new HashSet<string> {
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
				"ResetBounds",
				"ResetLocalBounds",
			},
			[typeof(global::UnityEngine.Renderer)] = new HashSet<string> {
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
				"ResetBounds",
				"ResetLocalBounds",
			},
			[typeof(global::UnityEngine.Projector)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.TrailRenderer)] = new HashSet<string> {
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
				"Clear",
				"ResetBounds",
				"ResetLocalBounds",
			},
			[typeof(global::UnityEngine.LineRenderer)] = new HashSet<string> {
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
				"ResetBounds",
				"ResetLocalBounds",
			},
			[typeof(global::UnityEngine.OcclusionPortal)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.OcclusionArea)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.LensFlare)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Light)] = new HashSet<string> {
				"get_cookie",
				"set_cookie",
				"get_name",
				"set_name",
				"Reset",
			},
			[typeof(global::UnityEngine.Skybox)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.MeshFilter)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.LightProbeProxyVolume)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.SkinnedMeshRenderer)] = new HashSet<string> {
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
				"ResetBounds",
				"ResetLocalBounds",
			},
			[typeof(global::UnityEngine.MeshRenderer)] = new HashSet<string> {
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
				"ResetBounds",
				"ResetLocalBounds",
			},
			[typeof(global::UnityEngine.LightProbeGroup)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.LODGroup)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.RectTransform)] = new HashSet<string> {
				"get_name",
				"set_name",
				"ForceUpdateRectTransforms",
				"DetachChildren",
				"SetAsFirstSibling",
				"SetAsLastSibling",
			},
			[typeof(global::UnityEngine.Transform)] = new HashSet<string> {
				"get_name",
				"set_name",
				"DetachChildren",
				"SetAsFirstSibling",
				"SetAsLastSibling",
			},
			[typeof(global::UnityEngine.SpriteRenderer)] = new HashSet<string> {
				"get_sprite",
				"set_sprite",
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
				"ResetBounds",
				"ResetLocalBounds",
			},
			[typeof(global::UnityEngine.Rendering.SortingGroup)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Playables.PlayableDirector)] = new HashSet<string> {
				"get_name",
				"set_name",
				"DeferredEvaluate",
				"Evaluate",
				"Play",
				"Stop",
				"Pause",
				"Resume",
			},
			[typeof(global::UnityEngine.Grid)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.GridLayout)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.ParticleSystem)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Play",
				"Pause",
				"Stop",
				"Clear",
				"AllocateAxisOfRotationAttribute",
				"AllocateMeshIndexAttribute",
			},
			[typeof(global::UnityEngine.ParticleSystemRenderer)] = new HashSet<string> {
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
				"ResetBounds",
				"ResetLocalBounds",
			},
			[typeof(global::UnityEngine.ParticleSystemForceField)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Rigidbody)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Sleep",
				"WakeUp",
				"ResetCenterOfMass",
				"ResetInertiaTensor",
			},
			[typeof(global::UnityEngine.Collider)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.CharacterController)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.MeshCollider)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.CapsuleCollider)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.BoxCollider)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.SphereCollider)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.ConstantForce)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Joint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.HingeJoint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.SpringJoint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.FixedJoint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.CharacterJoint)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.ConfigurableJoint)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Rigidbody2D)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Sleep",
				"WakeUp",
			},
			[typeof(global::UnityEngine.Collider2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.CircleCollider2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.CapsuleCollider2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.EdgeCollider2D)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Reset",
			},
			[typeof(global::UnityEngine.BoxCollider2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.PolygonCollider2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.CompositeCollider2D)] = new HashSet<string> {
				"get_name",
				"set_name",
				"GenerateGeometry",
			},
			[typeof(global::UnityEngine.Joint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.DistanceJoint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.FrictionJoint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.HingeJoint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.RelativeJoint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.SliderJoint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.TargetJoint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.FixedJoint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.WheelJoint2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.Effector2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.AreaEffector2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.PointEffector2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.PlatformEffector2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.SurfaceEffector2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.ConstantForce2D)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.SpriteMask)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Terrain)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Tree)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.TerrainCollider)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.TextMesh)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Tilemaps.Tilemap)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Tilemaps.TilemapRenderer)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.CanvasGroup)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.CanvasRenderer)] = new HashSet<string> {
				"get_name",
				"set_name",
				"DisableRectClipping",
				"SetTexture",
				"SetAlphaTexture",
				"Clear",
			},
			[typeof(global::UnityEngine.Canvas)] = new HashSet<string> {
				"get_sortingLayerName",
				"set_sortingLayerName",
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.WheelCollider)] = new HashSet<string> {
				"get_name",
				"set_name",
				"ResetSprungMasses",
			},
			[typeof(global::UnityEngine.WindZone)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Rendering.PostProcessing.PostProcessDebug)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Rendering.PostProcessing.PostProcessLayer)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.Rendering.PostProcessing.PostProcessVolume)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::TMPro.TextContainer)] = new HashSet<string> {
			},
			[typeof(global::TMPro.TextMeshPro)] = new HashSet<string> {
				"get_text",
				"set_text",
				"get_mainTexture",
				"get_name",
				"set_name",
			},
			[typeof(global::TMPro.TextMeshProUGUI)] = new HashSet<string> {
				"get_text",
				"set_text",
				"get_mainTexture",
				"get_name",
				"set_name",
			},
			[typeof(global::TMPro.TMP_Dropdown)] = new HashSet<string> {
			},
			[typeof(global::TMPro.TMP_InputField)] = new HashSet<string> {
			},
			[typeof(global::TMPro.TMP_ScrollbarEventHandler)] = new HashSet<string> {
			},
			[typeof(global::TMPro.TMP_SelectionCaret)] = new HashSet<string> {
			},
			[typeof(global::TMPro.TMP_SpriteAnimator)] = new HashSet<string> {
			},
			[typeof(global::TMPro.TMP_SubMesh)] = new HashSet<string> {
			},
			[typeof(global::TMPro.TMP_SubMeshUI)] = new HashSet<string> {
			},
			[typeof(global::TMPro.TMP_Text)] = new HashSet<string> {
			},
			[typeof(global::VRC.Udon.UdonBehaviour)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.UI.Button)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Select",
			},
			[typeof(global::UnityEngine.UI.Dropdown)] = new HashSet<string> {
				"get_name",
				"set_name",
				"RefreshShownValue",
				"ClearOptions",
				"Show",
				"Hide",
				"Select",
			},
			[typeof(global::UnityEngine.UI.Graphic)] = new HashSet<string> {
				"get_mainTexture",
				"get_name",
				"set_name",
				"SetAllDirty",
				"SetLayoutDirty",
				"SetVerticesDirty",
				"SetMaterialDirty",
				"SetRaycastDirty",
				"OnCullingChanged",
				"LayoutComplete",
				"GraphicUpdateComplete",
				"SetNativeSize",
			},
			[typeof(global::UnityEngine.UI.GraphicRaycaster)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.UI.Image)] = new HashSet<string> {
				"get_sprite",
				"set_sprite",
				"get_overrideSprite",
				"set_overrideSprite",
				"get_mainTexture",
				"get_name",
				"set_name",
				"DisableSpriteOptimizations",
				"OnBeforeSerialize",
				"OnAfterDeserialize",
				"SetNativeSize",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"RecalculateClipping",
				"RecalculateMasking",
				"SetAllDirty",
				"SetLayoutDirty",
				"SetVerticesDirty",
				"SetMaterialDirty",
				"SetRaycastDirty",
				"OnCullingChanged",
				"LayoutComplete",
				"GraphicUpdateComplete",
			},
			[typeof(global::UnityEngine.UI.InputField)] = new HashSet<string> {
				"get_text",
				"set_text",
				"get_name",
				"set_name",
				"ForceLabelUpdate",
				"LayoutComplete",
				"GraphicUpdateComplete",
				"ActivateInputField",
				"DeactivateInputField",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"Select",
			},
			[typeof(global::UnityEngine.UI.AspectRatioFitter)] = new HashSet<string> {
				"get_name",
				"set_name",
				"SetLayoutHorizontal",
				"SetLayoutVertical",
			},
			[typeof(global::UnityEngine.UI.CanvasScaler)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.UI.ContentSizeFitter)] = new HashSet<string> {
				"get_name",
				"set_name",
				"SetLayoutHorizontal",
				"SetLayoutVertical",
			},
			[typeof(global::UnityEngine.UI.GridLayoutGroup)] = new HashSet<string> {
				"get_name",
				"set_name",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"SetLayoutHorizontal",
				"SetLayoutVertical",
			},
			[typeof(global::UnityEngine.UI.HorizontalLayoutGroup)] = new HashSet<string> {
				"get_name",
				"set_name",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"SetLayoutHorizontal",
				"SetLayoutVertical",
			},
			[typeof(global::UnityEngine.UI.HorizontalOrVerticalLayoutGroup)] = new HashSet<string> {
				"get_name",
				"set_name",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"SetLayoutHorizontal",
				"SetLayoutVertical",
			},
			[typeof(global::UnityEngine.UI.LayoutElement)] = new HashSet<string> {
				"get_name",
				"set_name",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
			},
			[typeof(global::UnityEngine.UI.LayoutGroup)] = new HashSet<string> {
				"get_name",
				"set_name",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"SetLayoutHorizontal",
				"SetLayoutVertical",
			},
			[typeof(global::UnityEngine.UI.VerticalLayoutGroup)] = new HashSet<string> {
				"get_name",
				"set_name",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"SetLayoutHorizontal",
				"SetLayoutVertical",
			},
			[typeof(global::UnityEngine.UI.Mask)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.UI.MaskableGraphic)] = new HashSet<string> {
				"get_mainTexture",
				"get_name",
				"set_name",
				"RecalculateClipping",
				"RecalculateMasking",
				"SetAllDirty",
				"SetLayoutDirty",
				"SetVerticesDirty",
				"SetMaterialDirty",
				"SetRaycastDirty",
				"OnCullingChanged",
				"LayoutComplete",
				"GraphicUpdateComplete",
				"SetNativeSize",
			},
			[typeof(global::UnityEngine.UI.RawImage)] = new HashSet<string> {
				"get_mainTexture",
				"get_texture",
				"set_texture",
				"get_name",
				"set_name",
				"SetNativeSize",
				"RecalculateClipping",
				"RecalculateMasking",
				"SetAllDirty",
				"SetLayoutDirty",
				"SetVerticesDirty",
				"SetMaterialDirty",
				"SetRaycastDirty",
				"OnCullingChanged",
				"LayoutComplete",
				"GraphicUpdateComplete",
			},
			[typeof(global::UnityEngine.UI.RectMask2D)] = new HashSet<string> {
				"get_name",
				"set_name",
				"PerformClipping",
				"UpdateClipSoftness",
			},
			[typeof(global::UnityEngine.UI.Scrollbar)] = new HashSet<string> {
				"get_name",
				"set_name",
				"LayoutComplete",
				"GraphicUpdateComplete",
				"Select",
			},
			[typeof(global::UnityEngine.UI.ScrollRect)] = new HashSet<string> {
				"get_name",
				"set_name",
				"LayoutComplete",
				"GraphicUpdateComplete",
				"StopMovement",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"SetLayoutHorizontal",
				"SetLayoutVertical",
			},
			[typeof(global::UnityEngine.UI.Selectable)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Select",
			},
			[typeof(global::UnityEngine.UI.Slider)] = new HashSet<string> {
				"get_name",
				"set_name",
				"LayoutComplete",
				"GraphicUpdateComplete",
				"Select",
			},
			[typeof(global::UnityEngine.UI.Text)] = new HashSet<string> {
				"get_mainTexture",
				"get_text",
				"set_text",
				"get_name",
				"set_name",
				"FontTextureChanged",
				"CalculateLayoutInputHorizontal",
				"CalculateLayoutInputVertical",
				"RecalculateClipping",
				"RecalculateMasking",
				"SetAllDirty",
				"SetLayoutDirty",
				"SetVerticesDirty",
				"SetMaterialDirty",
				"SetRaycastDirty",
				"OnCullingChanged",
				"LayoutComplete",
				"GraphicUpdateComplete",
				"SetNativeSize",
			},
			[typeof(global::UnityEngine.UI.Toggle)] = new HashSet<string> {
				"get_name",
				"set_name",
				"LayoutComplete",
				"GraphicUpdateComplete",
				"Select",
			},
			[typeof(global::UnityEngine.UI.ToggleGroup)] = new HashSet<string> {
				"get_name",
				"set_name",
				"EnsureValidState",
			},
			[typeof(global::UnityEngine.UI.BaseMeshEffect)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.UI.Outline)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.UI.PositionAsUV1)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.UI.Shadow)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::UnityEngine.EventSystems.EventSystem)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.EventSystems.EventTrigger)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.EventSystems.BaseInput)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.EventSystems.BaseInputModule)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.EventSystems.PointerInputModule)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.EventSystems.StandaloneInputModule)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.EventSystems.BaseRaycaster)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.EventSystems.PhysicsRaycaster)] = new HashSet<string> {
			},
			[typeof(global::UnityEngine.EventSystems.UIBehaviour)] = new HashSet<string> {
			},
			[typeof(global::ONSPAudioSource)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.Cinemachine3rdPersonAim)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineBlendListCamera)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineBrain)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineClearShot)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineCollider)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineConfiner)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineDollyCart)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::Cinemachine.CinemachineExternalCamera)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineFollowZoom)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineFreeLook)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineMixingCamera)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachinePath)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachinePipeline)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachinePixelPerfect)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineSmoothPath)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineStateDrivenCamera)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineStoryboard)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineTargetGroup)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineVirtualCamera)] = new HashSet<string> {
				"get_Description",
				"get_name",
				"set_name",
				"MoveToTopOfPrioritySubqueue",
			},
			[typeof(global::Cinemachine.Cinemachine3rdPersonFollow)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineBasicMultiChannelPerlin)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineComposer)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineFramingTransposer)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineGroupComposer)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineHardLockToTarget)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineHardLookAt)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineOrbitalTransposer)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachinePOV)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineSameAsFollowTarget)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineTrackedDolly)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineTransposer)] = new HashSet<string> {
			},
			[typeof(global::Cinemachine.CinemachineCore)] = new HashSet<string> {
			},
			[typeof(global::VRC.SDK3.Video.Components.Base.BaseVRCVideoPlayer)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Play",
				"Pause",
				"Stop",
			},
			[typeof(global::VRC.SDK3.Video.Components.AVPro.VRCAVProVideoScreen)] = new HashSet<string> {
			},
			[typeof(global::VRC.SDK3.Video.Components.AVPro.VRCAVProVideoSpeaker)] = new HashSet<string> {
			},
			[typeof(global::VRC.SDK3.Midi.VRCMidiPlayer)] = new HashSet<string> {
				"Play",
				"Stop",
			},
			[typeof(global::VRC.SDK3.Midi.VRCMidiListener)] = new HashSet<string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCSpatialAudioSource)] = new HashSet<string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCObjectPool)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Shuffle",
			},
			[typeof(global::VRC.SDK3.Components.VRCVisualDamage)] = new HashSet<string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCAvatarPedestal)] = new HashSet<string> {
				"get_name",
				"set_name",
				"SwitchAvatar",
			},
			[typeof(global::VRC.SDK3.Components.VRCObjectSync)] = new HashSet<string> {
				"get_name",
				"set_name",
				"FlagDiscontinuity",
				"Respawn",
			},
			[typeof(global::VRC.SDK3.Components.VRCPickup)] = new HashSet<string> {
				"get_name",
				"set_name",
				"Drop",
				"PlayHaptics",
			},
			[typeof(global::VRC.SDK3.Components.VRCPortalMarker)] = new HashSet<string> {
				"get_name",
				"set_name",
				"RefreshPortal",
			},
			[typeof(global::VRC.SDK3.Components.VRCMirrorReflection)] = new HashSet<string> {
				"get_name",
				"set_name",
				"OnWillRenderObject",
			},
			[typeof(global::VRC.SDK3.Components.VRCSceneDescriptor)] = new HashSet<string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCStation)] = new HashSet<string> {
				"get_name",
				"set_name",
			},
			[typeof(global::VRC.SDK3.Components.VRCInputFieldKeyboardOverride)] = new HashSet<string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCUiShape)] = new HashSet<string> {
			},
			[typeof(global::VRCProjectSettings)] = new HashSet<string> {
			},
			[typeof(global::VRC.Core.PipelineManager)] = new HashSet<string> {
			},
		};
	}
}


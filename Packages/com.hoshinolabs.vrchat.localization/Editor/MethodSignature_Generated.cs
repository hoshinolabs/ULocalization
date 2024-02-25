using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoshinoLabs.Localization {
	internal static partial class MethodSignature {
		static Dictionary<Type, Dictionary<string, string>> methodSignatures = new Dictionary<Type, Dictionary<string, string>>() {
			[typeof(global::UnityEngine.AI.NavMeshAgent)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAINavMeshAgent.__get_name__SystemString",
				["set_name"] = "UnityEngineAINavMeshAgent.__set_name__SystemString__SystemVoid",
				["CompleteOffMeshLink"] = "UnityEngineAINavMeshAgent.__CompleteOffMeshLink__SystemVoid",
				["ResetPath"] = "UnityEngineAINavMeshAgent.__ResetPath__SystemVoid",
			},
			[typeof(global::UnityEngine.AI.NavMeshObstacle)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAINavMeshObstacle.__get_name__SystemString",
				["set_name"] = "UnityEngineAINavMeshObstacle.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AI.OffMeshLink)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAIOffMeshLink.__get_name__SystemString",
				["set_name"] = "UnityEngineAIOffMeshLink.__set_name__SystemString__SystemVoid",
				["UpdatePositions"] = "UnityEngineAIOffMeshLink.__UpdatePositions__SystemVoid",
			},
			[typeof(global::UnityEngine.Animator)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAnimator.__get_name__SystemString",
				["set_name"] = "UnityEngineAnimator.__set_name__SystemString__SystemVoid",
				["SetTrigger"] = "UnityEngineAnimator.__SetTrigger__SystemString__SystemVoid",
				["ResetTrigger"] = "UnityEngineAnimator.__ResetTrigger__SystemString__SystemVoid",
				["InterruptMatchTarget"] = "UnityEngineAnimator.__InterruptMatchTarget__SystemVoid",
				["WriteDefaultValues"] = "UnityEngineAnimator.__WriteDefaultValues__SystemVoid",
				["PlayInFixedTime"] = "UnityEngineAnimator.__PlayInFixedTime__SystemString__SystemVoid",
				["Play"] = "UnityEngineAnimator.__Play__SystemString__SystemVoid",
				["StartPlayback"] = "UnityEngineAnimator.__StartPlayback__SystemVoid",
				["StopPlayback"] = "UnityEngineAnimator.__StopPlayback__SystemVoid",
				["StopRecording"] = "UnityEngineAnimator.__StopRecording__SystemVoid",
				["Rebind"] = "UnityEngineAnimator.__Rebind__SystemVoid",
				["ApplyBuiltinRootMotion"] = "UnityEngineAnimator.__ApplyBuiltinRootMotion__SystemVoid",
			},
			[typeof(global::UnityEngine.Animations.AimConstraint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAnimationsAimConstraint.__get_name__SystemString",
				["set_name"] = "UnityEngineAnimationsAimConstraint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Animations.PositionConstraint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAnimationsPositionConstraint.__get_name__SystemString",
				["set_name"] = "UnityEngineAnimationsPositionConstraint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Animations.RotationConstraint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAnimationsRotationConstraint.__get_name__SystemString",
				["set_name"] = "UnityEngineAnimationsRotationConstraint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Animations.ScaleConstraint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAnimationsScaleConstraint.__get_name__SystemString",
				["set_name"] = "UnityEngineAnimationsScaleConstraint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Animations.LookAtConstraint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAnimationsLookAtConstraint.__get_name__SystemString",
				["set_name"] = "UnityEngineAnimationsLookAtConstraint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Animations.ParentConstraint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAnimationsParentConstraint.__get_name__SystemString",
				["set_name"] = "UnityEngineAnimationsParentConstraint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AudioSource)] = new Dictionary<string, string> {
				["get_clip"] = "UnityEngineAudioSource.__get_clip__UnityEngineAudioClip",
				["set_clip"] = "UnityEngineAudioSource.__set_clip__UnityEngineAudioClip__SystemVoid",
				["get_name"] = "UnityEngineAudioSource.__get_name__SystemString",
				["set_name"] = "UnityEngineAudioSource.__set_name__SystemString__SystemVoid",
				["Play"] = "UnityEngineAudioSource.__Play__SystemVoid",
				["PlayOneShot"] = "UnityEngineAudioSource.__PlayOneShot__UnityEngineAudioClip__SystemVoid",
				["Stop"] = "UnityEngineAudioSource.__Stop__SystemVoid",
				["Pause"] = "UnityEngineAudioSource.__Pause__SystemVoid",
				["UnPause"] = "UnityEngineAudioSource.__UnPause__SystemVoid",
			},
			[typeof(global::UnityEngine.AudioLowPassFilter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAudioLowPassFilter.__get_name__SystemString",
				["set_name"] = "UnityEngineAudioLowPassFilter.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AudioHighPassFilter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAudioHighPassFilter.__get_name__SystemString",
				["set_name"] = "UnityEngineAudioHighPassFilter.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AudioReverbFilter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAudioReverbFilter.__get_name__SystemString",
				["set_name"] = "UnityEngineAudioReverbFilter.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AudioListener)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.AudioReverbZone)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAudioReverbZone.__get_name__SystemString",
				["set_name"] = "UnityEngineAudioReverbZone.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AudioDistortionFilter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAudioDistortionFilter.__get_name__SystemString",
				["set_name"] = "UnityEngineAudioDistortionFilter.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AudioEchoFilter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAudioEchoFilter.__get_name__SystemString",
				["set_name"] = "UnityEngineAudioEchoFilter.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AudioChorusFilter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAudioChorusFilter.__get_name__SystemString",
				["set_name"] = "UnityEngineAudioChorusFilter.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Cloth)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Camera)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCamera.__get_name__SystemString",
				["set_name"] = "UnityEngineCamera.__set_name__SystemString__SystemVoid",
				["Reset"] = "UnityEngineCamera.__Reset__SystemVoid",
				["ResetTransparencySortSettings"] = "UnityEngineCamera.__ResetTransparencySortSettings__SystemVoid",
				["ResetAspect"] = "UnityEngineCamera.__ResetAspect__SystemVoid",
				["ResetCullingMatrix"] = "UnityEngineCamera.__ResetCullingMatrix__SystemVoid",
				["ResetReplacementShader"] = "UnityEngineCamera.__ResetReplacementShader__SystemVoid",
				["ResetWorldToCameraMatrix"] = "UnityEngineCamera.__ResetWorldToCameraMatrix__SystemVoid",
				["ResetProjectionMatrix"] = "UnityEngineCamera.__ResetProjectionMatrix__SystemVoid",
				["ResetStereoProjectionMatrices"] = "UnityEngineCamera.__ResetStereoProjectionMatrices__SystemVoid",
				["ResetStereoViewMatrices"] = "UnityEngineCamera.__ResetStereoViewMatrices__SystemVoid",
				["Render"] = "UnityEngineCamera.__Render__SystemVoid",
				["RenderDontRestore"] = "UnityEngineCamera.__RenderDontRestore__SystemVoid",
			},
			[typeof(global::UnityEngine.FlareLayer)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.ReflectionProbe)] = new Dictionary<string, string> {
				["get_bakedTexture"] = "UnityEngineReflectionProbe.__get_bakedTexture__UnityEngineTexture",
				["set_bakedTexture"] = "UnityEngineReflectionProbe.__set_bakedTexture__UnityEngineTexture__SystemVoid",
				["get_customBakedTexture"] = "UnityEngineReflectionProbe.__get_customBakedTexture__UnityEngineTexture",
				["set_customBakedTexture"] = "UnityEngineReflectionProbe.__set_customBakedTexture__UnityEngineTexture__SystemVoid",
				["get_texture"] = "UnityEngineReflectionProbe.__get_texture__UnityEngineTexture",
				["get_name"] = "UnityEngineReflectionProbe.__get_name__SystemString",
				["set_name"] = "UnityEngineReflectionProbe.__set_name__SystemString__SystemVoid",
				["Reset"] = "UnityEngineReflectionProbe.__Reset__SystemVoid",
			},
			[typeof(global::UnityEngine.BillboardRenderer)] = new Dictionary<string, string> {
				["get_sortingLayerName"] = "UnityEngineBillboardRenderer.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineBillboardRenderer.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineBillboardRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineBillboardRenderer.__set_name__SystemString__SystemVoid",
				["ResetBounds"] = "UnityEngineBillboardRenderer.__ResetBounds__SystemVoid",
				["ResetLocalBounds"] = "UnityEngineBillboardRenderer.__ResetLocalBounds__SystemVoid",
			},
			[typeof(global::UnityEngine.Renderer)] = new Dictionary<string, string> {
				["get_sortingLayerName"] = "UnityEngineRenderer.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineRenderer.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineRenderer.__set_name__SystemString__SystemVoid",
				["ResetBounds"] = "UnityEngineRenderer.__ResetBounds__SystemVoid",
				["ResetLocalBounds"] = "UnityEngineRenderer.__ResetLocalBounds__SystemVoid",
			},
			[typeof(global::UnityEngine.Projector)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.TrailRenderer)] = new Dictionary<string, string> {
				["get_sortingLayerName"] = "UnityEngineTrailRenderer.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineTrailRenderer.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineTrailRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineTrailRenderer.__set_name__SystemString__SystemVoid",
				["Clear"] = "UnityEngineTrailRenderer.__Clear__SystemVoid",
				["ResetBounds"] = "UnityEngineTrailRenderer.__ResetBounds__SystemVoid",
				["ResetLocalBounds"] = "UnityEngineTrailRenderer.__ResetLocalBounds__SystemVoid",
			},
			[typeof(global::UnityEngine.LineRenderer)] = new Dictionary<string, string> {
				["get_sortingLayerName"] = "UnityEngineLineRenderer.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineLineRenderer.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineLineRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineLineRenderer.__set_name__SystemString__SystemVoid",
				["ResetBounds"] = "UnityEngineLineRenderer.__ResetBounds__SystemVoid",
				["ResetLocalBounds"] = "UnityEngineLineRenderer.__ResetLocalBounds__SystemVoid",
			},
			[typeof(global::UnityEngine.OcclusionPortal)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineOcclusionPortal.__get_name__SystemString",
				["set_name"] = "UnityEngineOcclusionPortal.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.OcclusionArea)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.LensFlare)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Light)] = new Dictionary<string, string> {
				["get_cookie"] = "UnityEngineLight.__get_cookie__UnityEngineTexture",
				["set_cookie"] = "UnityEngineLight.__set_cookie__UnityEngineTexture__SystemVoid",
				["get_name"] = "UnityEngineLight.__get_name__SystemString",
				["set_name"] = "UnityEngineLight.__set_name__SystemString__SystemVoid",
				["Reset"] = "UnityEngineLight.__Reset__SystemVoid",
			},
			[typeof(global::UnityEngine.Skybox)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.MeshFilter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineMeshFilter.__get_name__SystemString",
				["set_name"] = "UnityEngineMeshFilter.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.LightProbeProxyVolume)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.SkinnedMeshRenderer)] = new Dictionary<string, string> {
				["get_sortingLayerName"] = "UnityEngineSkinnedMeshRenderer.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineSkinnedMeshRenderer.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineSkinnedMeshRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineSkinnedMeshRenderer.__set_name__SystemString__SystemVoid",
				["ResetBounds"] = "UnityEngineSkinnedMeshRenderer.__ResetBounds__SystemVoid",
				["ResetLocalBounds"] = "UnityEngineSkinnedMeshRenderer.__ResetLocalBounds__SystemVoid",
			},
			[typeof(global::UnityEngine.MeshRenderer)] = new Dictionary<string, string> {
				["get_sortingLayerName"] = "UnityEngineMeshRenderer.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineMeshRenderer.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineMeshRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineMeshRenderer.__set_name__SystemString__SystemVoid",
				["ResetBounds"] = "UnityEngineMeshRenderer.__ResetBounds__SystemVoid",
				["ResetLocalBounds"] = "UnityEngineMeshRenderer.__ResetLocalBounds__SystemVoid",
			},
			[typeof(global::UnityEngine.LightProbeGroup)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.LODGroup)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.RectTransform)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineRectTransform.__get_name__SystemString",
				["set_name"] = "UnityEngineRectTransform.__set_name__SystemString__SystemVoid",
				["ForceUpdateRectTransforms"] = "UnityEngineRectTransform.__ForceUpdateRectTransforms__SystemVoid",
				["DetachChildren"] = "UnityEngineRectTransform.__DetachChildren__SystemVoid",
				["SetAsFirstSibling"] = "UnityEngineRectTransform.__SetAsFirstSibling__SystemVoid",
				["SetAsLastSibling"] = "UnityEngineRectTransform.__SetAsLastSibling__SystemVoid",
			},
			[typeof(global::UnityEngine.Transform)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineTransform.__get_name__SystemString",
				["set_name"] = "UnityEngineTransform.__set_name__SystemString__SystemVoid",
				["DetachChildren"] = "UnityEngineTransform.__DetachChildren__SystemVoid",
				["SetAsFirstSibling"] = "UnityEngineTransform.__SetAsFirstSibling__SystemVoid",
				["SetAsLastSibling"] = "UnityEngineTransform.__SetAsLastSibling__SystemVoid",
			},
			[typeof(global::UnityEngine.SpriteRenderer)] = new Dictionary<string, string> {
				["get_sprite"] = "UnityEngineSpriteRenderer.__get_sprite__UnityEngineSprite",
				["set_sprite"] = "UnityEngineSpriteRenderer.__set_sprite__UnityEngineSprite__SystemVoid",
				["get_sortingLayerName"] = "UnityEngineSpriteRenderer.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineSpriteRenderer.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineSpriteRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineSpriteRenderer.__set_name__SystemString__SystemVoid",
				["ResetBounds"] = "UnityEngineSpriteRenderer.__ResetBounds__SystemVoid",
				["ResetLocalBounds"] = "UnityEngineSpriteRenderer.__ResetLocalBounds__SystemVoid",
			},
			[typeof(global::UnityEngine.Rendering.SortingGroup)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Playables.PlayableDirector)] = new Dictionary<string, string> {
				["get_name"] = "UnityEnginePlayablesPlayableDirector.__get_name__SystemString",
				["set_name"] = "UnityEnginePlayablesPlayableDirector.__set_name__SystemString__SystemVoid",
				["DeferredEvaluate"] = "UnityEnginePlayablesPlayableDirector.__DeferredEvaluate__SystemVoid",
				["Evaluate"] = "UnityEnginePlayablesPlayableDirector.__Evaluate__SystemVoid",
				["Play"] = "UnityEnginePlayablesPlayableDirector.__Play__SystemVoid",
				["Stop"] = "UnityEnginePlayablesPlayableDirector.__Stop__SystemVoid",
				["Pause"] = "UnityEnginePlayablesPlayableDirector.__Pause__SystemVoid",
				["Resume"] = "UnityEnginePlayablesPlayableDirector.__Resume__SystemVoid",
			},
			[typeof(global::UnityEngine.Grid)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.GridLayout)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.ParticleSystem)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineParticleSystem.__get_name__SystemString",
				["set_name"] = "UnityEngineParticleSystem.__set_name__SystemString__SystemVoid",
				["Play"] = "UnityEngineParticleSystem.__Play__SystemVoid",
				["Pause"] = "UnityEngineParticleSystem.__Pause__SystemVoid",
				["Stop"] = "UnityEngineParticleSystem.__Stop__SystemVoid",
				["Clear"] = "UnityEngineParticleSystem.__Clear__SystemVoid",
				["AllocateAxisOfRotationAttribute"] = "UnityEngineParticleSystem.__AllocateAxisOfRotationAttribute__SystemVoid",
				["AllocateMeshIndexAttribute"] = "UnityEngineParticleSystem.__AllocateMeshIndexAttribute__SystemVoid",
			},
			[typeof(global::UnityEngine.ParticleSystemRenderer)] = new Dictionary<string, string> {
				["get_sortingLayerName"] = "UnityEngineParticleSystemRenderer.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineParticleSystemRenderer.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineParticleSystemRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineParticleSystemRenderer.__set_name__SystemString__SystemVoid",
				["ResetBounds"] = "UnityEngineParticleSystemRenderer.__ResetBounds__SystemVoid",
				["ResetLocalBounds"] = "UnityEngineParticleSystemRenderer.__ResetLocalBounds__SystemVoid",
			},
			[typeof(global::UnityEngine.ParticleSystemForceField)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Rigidbody)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineRigidbody.__get_name__SystemString",
				["set_name"] = "UnityEngineRigidbody.__set_name__SystemString__SystemVoid",
				["Sleep"] = "UnityEngineRigidbody.__Sleep__SystemVoid",
				["WakeUp"] = "UnityEngineRigidbody.__WakeUp__SystemVoid",
				["ResetCenterOfMass"] = "UnityEngineRigidbody.__ResetCenterOfMass__SystemVoid",
				["ResetInertiaTensor"] = "UnityEngineRigidbody.__ResetInertiaTensor__SystemVoid",
			},
			[typeof(global::UnityEngine.Collider)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCollider.__get_name__SystemString",
				["set_name"] = "UnityEngineCollider.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.CharacterController)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCharacterController.__get_name__SystemString",
				["set_name"] = "UnityEngineCharacterController.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.MeshCollider)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineMeshCollider.__get_name__SystemString",
				["set_name"] = "UnityEngineMeshCollider.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.CapsuleCollider)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCapsuleCollider.__get_name__SystemString",
				["set_name"] = "UnityEngineCapsuleCollider.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.BoxCollider)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineBoxCollider.__get_name__SystemString",
				["set_name"] = "UnityEngineBoxCollider.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.SphereCollider)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineSphereCollider.__get_name__SystemString",
				["set_name"] = "UnityEngineSphereCollider.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.ConstantForce)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineConstantForce.__get_name__SystemString",
				["set_name"] = "UnityEngineConstantForce.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Joint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineJoint.__get_name__SystemString",
				["set_name"] = "UnityEngineJoint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.HingeJoint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineHingeJoint.__get_name__SystemString",
				["set_name"] = "UnityEngineHingeJoint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.SpringJoint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineSpringJoint.__get_name__SystemString",
				["set_name"] = "UnityEngineSpringJoint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.FixedJoint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineFixedJoint.__get_name__SystemString",
				["set_name"] = "UnityEngineFixedJoint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.CharacterJoint)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.ConfigurableJoint)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineConfigurableJoint.__get_name__SystemString",
				["set_name"] = "UnityEngineConfigurableJoint.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Rigidbody2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineRigidbody2D.__get_name__SystemString",
				["set_name"] = "UnityEngineRigidbody2D.__set_name__SystemString__SystemVoid",
				["Sleep"] = "UnityEngineRigidbody2D.__Sleep__SystemVoid",
				["WakeUp"] = "UnityEngineRigidbody2D.__WakeUp__SystemVoid",
			},
			[typeof(global::UnityEngine.Collider2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCollider2D.__get_name__SystemString",
				["set_name"] = "UnityEngineCollider2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.CircleCollider2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCircleCollider2D.__get_name__SystemString",
				["set_name"] = "UnityEngineCircleCollider2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.CapsuleCollider2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCapsuleCollider2D.__get_name__SystemString",
				["set_name"] = "UnityEngineCapsuleCollider2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.EdgeCollider2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineEdgeCollider2D.__get_name__SystemString",
				["set_name"] = "UnityEngineEdgeCollider2D.__set_name__SystemString__SystemVoid",
				["Reset"] = "UnityEngineEdgeCollider2D.__Reset__SystemVoid",
			},
			[typeof(global::UnityEngine.BoxCollider2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineBoxCollider2D.__get_name__SystemString",
				["set_name"] = "UnityEngineBoxCollider2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.PolygonCollider2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEnginePolygonCollider2D.__get_name__SystemString",
				["set_name"] = "UnityEnginePolygonCollider2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.CompositeCollider2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCompositeCollider2D.__get_name__SystemString",
				["set_name"] = "UnityEngineCompositeCollider2D.__set_name__SystemString__SystemVoid",
				["GenerateGeometry"] = "UnityEngineCompositeCollider2D.__GenerateGeometry__SystemVoid",
			},
			[typeof(global::UnityEngine.Joint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.DistanceJoint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineDistanceJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineDistanceJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.FrictionJoint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineFrictionJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineFrictionJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.HingeJoint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineHingeJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineHingeJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.RelativeJoint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineRelativeJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineRelativeJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.SliderJoint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineSliderJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineSliderJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.TargetJoint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineTargetJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineTargetJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.FixedJoint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineFixedJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineFixedJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.WheelJoint2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineWheelJoint2D.__get_name__SystemString",
				["set_name"] = "UnityEngineWheelJoint2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.Effector2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineEffector2D.__get_name__SystemString",
				["set_name"] = "UnityEngineEffector2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.AreaEffector2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineAreaEffector2D.__get_name__SystemString",
				["set_name"] = "UnityEngineAreaEffector2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.PointEffector2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEnginePointEffector2D.__get_name__SystemString",
				["set_name"] = "UnityEnginePointEffector2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.PlatformEffector2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEnginePlatformEffector2D.__get_name__SystemString",
				["set_name"] = "UnityEnginePlatformEffector2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.SurfaceEffector2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineSurfaceEffector2D.__get_name__SystemString",
				["set_name"] = "UnityEngineSurfaceEffector2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.ConstantForce2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineConstantForce2D.__get_name__SystemString",
				["set_name"] = "UnityEngineConstantForce2D.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.SpriteMask)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Terrain)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Tree)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.TerrainCollider)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.TextMesh)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Tilemaps.Tilemap)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Tilemaps.TilemapRenderer)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.CanvasGroup)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCanvasGroup.__get_name__SystemString",
				["set_name"] = "UnityEngineCanvasGroup.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.CanvasRenderer)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineCanvasRenderer.__get_name__SystemString",
				["set_name"] = "UnityEngineCanvasRenderer.__set_name__SystemString__SystemVoid",
				["DisableRectClipping"] = "UnityEngineCanvasRenderer.__DisableRectClipping__SystemVoid",
				["SetTexture"] = "UnityEngineCanvasRenderer.__SetTexture__UnityEngineTexture__SystemVoid",
				["SetAlphaTexture"] = "UnityEngineCanvasRenderer.__SetAlphaTexture__UnityEngineTexture__SystemVoid",
				["Clear"] = "UnityEngineCanvasRenderer.__Clear__SystemVoid",
			},
			[typeof(global::UnityEngine.Canvas)] = new Dictionary<string, string> {
				["get_sortingLayerName"] = "UnityEngineCanvas.__get_sortingLayerName__SystemString",
				["set_sortingLayerName"] = "UnityEngineCanvas.__set_sortingLayerName__SystemString__SystemVoid",
				["get_name"] = "UnityEngineCanvas.__get_name__SystemString",
				["set_name"] = "UnityEngineCanvas.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.WheelCollider)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineWheelCollider.__get_name__SystemString",
				["set_name"] = "UnityEngineWheelCollider.__set_name__SystemString__SystemVoid",
				["ResetSprungMasses"] = "UnityEngineWheelCollider.__ResetSprungMasses__SystemVoid",
			},
			[typeof(global::UnityEngine.WindZone)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Rendering.PostProcessing.PostProcessDebug)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Rendering.PostProcessing.PostProcessLayer)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.Rendering.PostProcessing.PostProcessVolume)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineRenderingPostProcessingPostProcessVolume.__get_name__SystemString",
				["set_name"] = "UnityEngineRenderingPostProcessingPostProcessVolume.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::TMPro.TextContainer)] = new Dictionary<string, string> {
			},
			[typeof(global::TMPro.TextMeshPro)] = new Dictionary<string, string> {
				["get_text"] = "TMProTextMeshPro.__get_text__SystemString",
				["set_text"] = "TMProTextMeshPro.__set_text__SystemString__SystemVoid",
				["get_mainTexture"] = "TMProTextMeshPro.__get_mainTexture__UnityEngineTexture",
				["get_name"] = "TMProTextMeshPro.__get_name__SystemString",
				["set_name"] = "TMProTextMeshPro.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::TMPro.TextMeshProUGUI)] = new Dictionary<string, string> {
				["get_text"] = "TMProTextMeshProUGUI.__get_text__SystemString",
				["set_text"] = "TMProTextMeshProUGUI.__set_text__SystemString__SystemVoid",
				["get_mainTexture"] = "TMProTextMeshProUGUI.__get_mainTexture__UnityEngineTexture",
				["get_name"] = "TMProTextMeshProUGUI.__get_name__SystemString",
				["set_name"] = "TMProTextMeshProUGUI.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::TMPro.TMP_Dropdown)] = new Dictionary<string, string> {
			},
			[typeof(global::TMPro.TMP_InputField)] = new Dictionary<string, string> {
			},
			[typeof(global::TMPro.TMP_ScrollbarEventHandler)] = new Dictionary<string, string> {
			},
			[typeof(global::TMPro.TMP_SelectionCaret)] = new Dictionary<string, string> {
			},
			[typeof(global::TMPro.TMP_SpriteAnimator)] = new Dictionary<string, string> {
			},
			[typeof(global::TMPro.TMP_SubMesh)] = new Dictionary<string, string> {
			},
			[typeof(global::TMPro.TMP_SubMeshUI)] = new Dictionary<string, string> {
			},
			[typeof(global::TMPro.TMP_Text)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.Udon.UdonBehaviour)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.UI.Button)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIButton.__get_name__SystemString",
				["set_name"] = "UnityEngineUIButton.__set_name__SystemString__SystemVoid",
				["Select"] = "UnityEngineUIButton.__Select__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Dropdown)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIDropdown.__get_name__SystemString",
				["set_name"] = "UnityEngineUIDropdown.__set_name__SystemString__SystemVoid",
				["RefreshShownValue"] = "UnityEngineUIDropdown.__RefreshShownValue__SystemVoid",
				["ClearOptions"] = "UnityEngineUIDropdown.__ClearOptions__SystemVoid",
				["Show"] = "UnityEngineUIDropdown.__Show__SystemVoid",
				["Hide"] = "UnityEngineUIDropdown.__Hide__SystemVoid",
				["Select"] = "UnityEngineUIDropdown.__Select__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Graphic)] = new Dictionary<string, string> {
				["get_mainTexture"] = "UnityEngineUIGraphic.__get_mainTexture__UnityEngineTexture",
				["get_name"] = "UnityEngineUIGraphic.__get_name__SystemString",
				["set_name"] = "UnityEngineUIGraphic.__set_name__SystemString__SystemVoid",
				["SetAllDirty"] = "UnityEngineUIGraphic.__SetAllDirty__SystemVoid",
				["SetLayoutDirty"] = "UnityEngineUIGraphic.__SetLayoutDirty__SystemVoid",
				["SetVerticesDirty"] = "UnityEngineUIGraphic.__SetVerticesDirty__SystemVoid",
				["SetMaterialDirty"] = "UnityEngineUIGraphic.__SetMaterialDirty__SystemVoid",
				["SetRaycastDirty"] = "UnityEngineUIGraphic.__SetRaycastDirty__SystemVoid",
				["OnCullingChanged"] = "UnityEngineUIGraphic.__OnCullingChanged__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIGraphic.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIGraphic.__GraphicUpdateComplete__SystemVoid",
				["SetNativeSize"] = "UnityEngineUIGraphic.__SetNativeSize__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.GraphicRaycaster)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIGraphicRaycaster.__get_name__SystemString",
				["set_name"] = "UnityEngineUIGraphicRaycaster.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Image)] = new Dictionary<string, string> {
				["get_sprite"] = "UnityEngineUIImage.__get_sprite__UnityEngineSprite",
				["set_sprite"] = "UnityEngineUIImage.__set_sprite__UnityEngineSprite__SystemVoid",
				["get_overrideSprite"] = "UnityEngineUIImage.__get_overrideSprite__UnityEngineSprite",
				["set_overrideSprite"] = "UnityEngineUIImage.__set_overrideSprite__UnityEngineSprite__SystemVoid",
				["get_mainTexture"] = "UnityEngineUIImage.__get_mainTexture__UnityEngineTexture",
				["get_name"] = "UnityEngineUIImage.__get_name__SystemString",
				["set_name"] = "UnityEngineUIImage.__set_name__SystemString__SystemVoid",
				["DisableSpriteOptimizations"] = "UnityEngineUIImage.__DisableSpriteOptimizations__SystemVoid",
				["OnBeforeSerialize"] = "UnityEngineUIImage.__OnBeforeSerialize__SystemVoid",
				["OnAfterDeserialize"] = "UnityEngineUIImage.__OnAfterDeserialize__SystemVoid",
				["SetNativeSize"] = "UnityEngineUIImage.__SetNativeSize__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUIImage.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUIImage.__CalculateLayoutInputVertical__SystemVoid",
				["RecalculateClipping"] = "UnityEngineUIImage.__RecalculateClipping__SystemVoid",
				["RecalculateMasking"] = "UnityEngineUIImage.__RecalculateMasking__SystemVoid",
				["SetAllDirty"] = "UnityEngineUIImage.__SetAllDirty__SystemVoid",
				["SetLayoutDirty"] = "UnityEngineUIImage.__SetLayoutDirty__SystemVoid",
				["SetVerticesDirty"] = "UnityEngineUIImage.__SetVerticesDirty__SystemVoid",
				["SetMaterialDirty"] = "UnityEngineUIImage.__SetMaterialDirty__SystemVoid",
				["SetRaycastDirty"] = "UnityEngineUIImage.__SetRaycastDirty__SystemVoid",
				["OnCullingChanged"] = "UnityEngineUIImage.__OnCullingChanged__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIImage.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIImage.__GraphicUpdateComplete__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.InputField)] = new Dictionary<string, string> {
				["get_text"] = "UnityEngineUIInputField.__get_text__SystemString",
				["set_text"] = "UnityEngineUIInputField.__set_text__SystemString__SystemVoid",
				["get_name"] = "UnityEngineUIInputField.__get_name__SystemString",
				["set_name"] = "UnityEngineUIInputField.__set_name__SystemString__SystemVoid",
				["ForceLabelUpdate"] = "UnityEngineUIInputField.__ForceLabelUpdate__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIInputField.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIInputField.__GraphicUpdateComplete__SystemVoid",
				["ActivateInputField"] = "UnityEngineUIInputField.__ActivateInputField__SystemVoid",
				["DeactivateInputField"] = "UnityEngineUIInputField.__DeactivateInputField__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUIInputField.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUIInputField.__CalculateLayoutInputVertical__SystemVoid",
				["Select"] = "UnityEngineUIInputField.__Select__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.AspectRatioFitter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIAspectRatioFitter.__get_name__SystemString",
				["set_name"] = "UnityEngineUIAspectRatioFitter.__set_name__SystemString__SystemVoid",
				["SetLayoutHorizontal"] = "UnityEngineUIAspectRatioFitter.__SetLayoutHorizontal__SystemVoid",
				["SetLayoutVertical"] = "UnityEngineUIAspectRatioFitter.__SetLayoutVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.CanvasScaler)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUICanvasScaler.__get_name__SystemString",
				["set_name"] = "UnityEngineUICanvasScaler.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.ContentSizeFitter)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIContentSizeFitter.__get_name__SystemString",
				["set_name"] = "UnityEngineUIContentSizeFitter.__set_name__SystemString__SystemVoid",
				["SetLayoutHorizontal"] = "UnityEngineUIContentSizeFitter.__SetLayoutHorizontal__SystemVoid",
				["SetLayoutVertical"] = "UnityEngineUIContentSizeFitter.__SetLayoutVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.GridLayoutGroup)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIGridLayoutGroup.__get_name__SystemString",
				["set_name"] = "UnityEngineUIGridLayoutGroup.__set_name__SystemString__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUIGridLayoutGroup.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUIGridLayoutGroup.__CalculateLayoutInputVertical__SystemVoid",
				["SetLayoutHorizontal"] = "UnityEngineUIGridLayoutGroup.__SetLayoutHorizontal__SystemVoid",
				["SetLayoutVertical"] = "UnityEngineUIGridLayoutGroup.__SetLayoutVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.HorizontalLayoutGroup)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIHorizontalLayoutGroup.__get_name__SystemString",
				["set_name"] = "UnityEngineUIHorizontalLayoutGroup.__set_name__SystemString__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUIHorizontalLayoutGroup.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUIHorizontalLayoutGroup.__CalculateLayoutInputVertical__SystemVoid",
				["SetLayoutHorizontal"] = "UnityEngineUIHorizontalLayoutGroup.__SetLayoutHorizontal__SystemVoid",
				["SetLayoutVertical"] = "UnityEngineUIHorizontalLayoutGroup.__SetLayoutVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.HorizontalOrVerticalLayoutGroup)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIHorizontalOrVerticalLayoutGroup.__get_name__SystemString",
				["set_name"] = "UnityEngineUIHorizontalOrVerticalLayoutGroup.__set_name__SystemString__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUIHorizontalOrVerticalLayoutGroup.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUIHorizontalOrVerticalLayoutGroup.__CalculateLayoutInputVertical__SystemVoid",
				["SetLayoutHorizontal"] = "UnityEngineUIHorizontalOrVerticalLayoutGroup.__SetLayoutHorizontal__SystemVoid",
				["SetLayoutVertical"] = "UnityEngineUIHorizontalOrVerticalLayoutGroup.__SetLayoutVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.LayoutElement)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUILayoutElement.__get_name__SystemString",
				["set_name"] = "UnityEngineUILayoutElement.__set_name__SystemString__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUILayoutElement.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUILayoutElement.__CalculateLayoutInputVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.LayoutGroup)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUILayoutGroup.__get_name__SystemString",
				["set_name"] = "UnityEngineUILayoutGroup.__set_name__SystemString__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUILayoutGroup.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUILayoutGroup.__CalculateLayoutInputVertical__SystemVoid",
				["SetLayoutHorizontal"] = "UnityEngineUILayoutGroup.__SetLayoutHorizontal__SystemVoid",
				["SetLayoutVertical"] = "UnityEngineUILayoutGroup.__SetLayoutVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.VerticalLayoutGroup)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIVerticalLayoutGroup.__get_name__SystemString",
				["set_name"] = "UnityEngineUIVerticalLayoutGroup.__set_name__SystemString__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUIVerticalLayoutGroup.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUIVerticalLayoutGroup.__CalculateLayoutInputVertical__SystemVoid",
				["SetLayoutHorizontal"] = "UnityEngineUIVerticalLayoutGroup.__SetLayoutHorizontal__SystemVoid",
				["SetLayoutVertical"] = "UnityEngineUIVerticalLayoutGroup.__SetLayoutVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Mask)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIMask.__get_name__SystemString",
				["set_name"] = "UnityEngineUIMask.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.MaskableGraphic)] = new Dictionary<string, string> {
				["get_mainTexture"] = "UnityEngineUIMaskableGraphic.__get_mainTexture__UnityEngineTexture",
				["get_name"] = "UnityEngineUIMaskableGraphic.__get_name__SystemString",
				["set_name"] = "UnityEngineUIMaskableGraphic.__set_name__SystemString__SystemVoid",
				["RecalculateClipping"] = "UnityEngineUIMaskableGraphic.__RecalculateClipping__SystemVoid",
				["RecalculateMasking"] = "UnityEngineUIMaskableGraphic.__RecalculateMasking__SystemVoid",
				["SetAllDirty"] = "UnityEngineUIMaskableGraphic.__SetAllDirty__SystemVoid",
				["SetLayoutDirty"] = "UnityEngineUIMaskableGraphic.__SetLayoutDirty__SystemVoid",
				["SetVerticesDirty"] = "UnityEngineUIMaskableGraphic.__SetVerticesDirty__SystemVoid",
				["SetMaterialDirty"] = "UnityEngineUIMaskableGraphic.__SetMaterialDirty__SystemVoid",
				["SetRaycastDirty"] = "UnityEngineUIMaskableGraphic.__SetRaycastDirty__SystemVoid",
				["OnCullingChanged"] = "UnityEngineUIMaskableGraphic.__OnCullingChanged__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIMaskableGraphic.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIMaskableGraphic.__GraphicUpdateComplete__SystemVoid",
				["SetNativeSize"] = "UnityEngineUIMaskableGraphic.__SetNativeSize__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.RawImage)] = new Dictionary<string, string> {
				["get_mainTexture"] = "UnityEngineUIRawImage.__get_mainTexture__UnityEngineTexture",
				["get_texture"] = "UnityEngineUIRawImage.__get_texture__UnityEngineTexture",
				["set_texture"] = "UnityEngineUIRawImage.__set_texture__UnityEngineTexture__SystemVoid",
				["get_name"] = "UnityEngineUIRawImage.__get_name__SystemString",
				["set_name"] = "UnityEngineUIRawImage.__set_name__SystemString__SystemVoid",
				["SetNativeSize"] = "UnityEngineUIRawImage.__SetNativeSize__SystemVoid",
				["RecalculateClipping"] = "UnityEngineUIRawImage.__RecalculateClipping__SystemVoid",
				["RecalculateMasking"] = "UnityEngineUIRawImage.__RecalculateMasking__SystemVoid",
				["SetAllDirty"] = "UnityEngineUIRawImage.__SetAllDirty__SystemVoid",
				["SetLayoutDirty"] = "UnityEngineUIRawImage.__SetLayoutDirty__SystemVoid",
				["SetVerticesDirty"] = "UnityEngineUIRawImage.__SetVerticesDirty__SystemVoid",
				["SetMaterialDirty"] = "UnityEngineUIRawImage.__SetMaterialDirty__SystemVoid",
				["SetRaycastDirty"] = "UnityEngineUIRawImage.__SetRaycastDirty__SystemVoid",
				["OnCullingChanged"] = "UnityEngineUIRawImage.__OnCullingChanged__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIRawImage.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIRawImage.__GraphicUpdateComplete__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.RectMask2D)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIRectMask2D.__get_name__SystemString",
				["set_name"] = "UnityEngineUIRectMask2D.__set_name__SystemString__SystemVoid",
				["PerformClipping"] = "UnityEngineUIRectMask2D.__PerformClipping__SystemVoid",
				["UpdateClipSoftness"] = "UnityEngineUIRectMask2D.__UpdateClipSoftness__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Scrollbar)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIScrollbar.__get_name__SystemString",
				["set_name"] = "UnityEngineUIScrollbar.__set_name__SystemString__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIScrollbar.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIScrollbar.__GraphicUpdateComplete__SystemVoid",
				["Select"] = "UnityEngineUIScrollbar.__Select__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.ScrollRect)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIScrollRect.__get_name__SystemString",
				["set_name"] = "UnityEngineUIScrollRect.__set_name__SystemString__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIScrollRect.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIScrollRect.__GraphicUpdateComplete__SystemVoid",
				["StopMovement"] = "UnityEngineUIScrollRect.__StopMovement__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUIScrollRect.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUIScrollRect.__CalculateLayoutInputVertical__SystemVoid",
				["SetLayoutHorizontal"] = "UnityEngineUIScrollRect.__SetLayoutHorizontal__SystemVoid",
				["SetLayoutVertical"] = "UnityEngineUIScrollRect.__SetLayoutVertical__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Selectable)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUISelectable.__get_name__SystemString",
				["set_name"] = "UnityEngineUISelectable.__set_name__SystemString__SystemVoid",
				["Select"] = "UnityEngineUISelectable.__Select__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Slider)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUISlider.__get_name__SystemString",
				["set_name"] = "UnityEngineUISlider.__set_name__SystemString__SystemVoid",
				["LayoutComplete"] = "UnityEngineUISlider.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUISlider.__GraphicUpdateComplete__SystemVoid",
				["Select"] = "UnityEngineUISlider.__Select__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Text)] = new Dictionary<string, string> {
				["get_mainTexture"] = "UnityEngineUIText.__get_mainTexture__UnityEngineTexture",
				["get_text"] = "UnityEngineUIText.__get_text__SystemString",
				["set_text"] = "UnityEngineUIText.__set_text__SystemString__SystemVoid",
				["get_name"] = "UnityEngineUIText.__get_name__SystemString",
				["set_name"] = "UnityEngineUIText.__set_name__SystemString__SystemVoid",
				["FontTextureChanged"] = "UnityEngineUIText.__FontTextureChanged__SystemVoid",
				["CalculateLayoutInputHorizontal"] = "UnityEngineUIText.__CalculateLayoutInputHorizontal__SystemVoid",
				["CalculateLayoutInputVertical"] = "UnityEngineUIText.__CalculateLayoutInputVertical__SystemVoid",
				["RecalculateClipping"] = "UnityEngineUIText.__RecalculateClipping__SystemVoid",
				["RecalculateMasking"] = "UnityEngineUIText.__RecalculateMasking__SystemVoid",
				["SetAllDirty"] = "UnityEngineUIText.__SetAllDirty__SystemVoid",
				["SetLayoutDirty"] = "UnityEngineUIText.__SetLayoutDirty__SystemVoid",
				["SetVerticesDirty"] = "UnityEngineUIText.__SetVerticesDirty__SystemVoid",
				["SetMaterialDirty"] = "UnityEngineUIText.__SetMaterialDirty__SystemVoid",
				["SetRaycastDirty"] = "UnityEngineUIText.__SetRaycastDirty__SystemVoid",
				["OnCullingChanged"] = "UnityEngineUIText.__OnCullingChanged__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIText.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIText.__GraphicUpdateComplete__SystemVoid",
				["SetNativeSize"] = "UnityEngineUIText.__SetNativeSize__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Toggle)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIToggle.__get_name__SystemString",
				["set_name"] = "UnityEngineUIToggle.__set_name__SystemString__SystemVoid",
				["LayoutComplete"] = "UnityEngineUIToggle.__LayoutComplete__SystemVoid",
				["GraphicUpdateComplete"] = "UnityEngineUIToggle.__GraphicUpdateComplete__SystemVoid",
				["Select"] = "UnityEngineUIToggle.__Select__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.ToggleGroup)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIToggleGroup.__get_name__SystemString",
				["set_name"] = "UnityEngineUIToggleGroup.__set_name__SystemString__SystemVoid",
				["EnsureValidState"] = "UnityEngineUIToggleGroup.__EnsureValidState__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.BaseMeshEffect)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIBaseMeshEffect.__get_name__SystemString",
				["set_name"] = "UnityEngineUIBaseMeshEffect.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Outline)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIOutline.__get_name__SystemString",
				["set_name"] = "UnityEngineUIOutline.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.PositionAsUV1)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIPositionAsUV1.__get_name__SystemString",
				["set_name"] = "UnityEngineUIPositionAsUV1.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.UI.Shadow)] = new Dictionary<string, string> {
				["get_name"] = "UnityEngineUIShadow.__get_name__SystemString",
				["set_name"] = "UnityEngineUIShadow.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::UnityEngine.EventSystems.EventSystem)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.EventSystems.EventTrigger)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.EventSystems.BaseInput)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.EventSystems.BaseInputModule)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.EventSystems.PointerInputModule)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.EventSystems.StandaloneInputModule)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.EventSystems.BaseRaycaster)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.EventSystems.PhysicsRaycaster)] = new Dictionary<string, string> {
			},
			[typeof(global::UnityEngine.EventSystems.UIBehaviour)] = new Dictionary<string, string> {
			},
			[typeof(global::ONSPAudioSource)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.Cinemachine3rdPersonAim)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineBlendListCamera)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineBrain)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineClearShot)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineCollider)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineConfiner)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineDollyCart)] = new Dictionary<string, string> {
				["get_name"] = "CinemachineCinemachineDollyCart.__get_name__SystemString",
				["set_name"] = "CinemachineCinemachineDollyCart.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::Cinemachine.CinemachineExternalCamera)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineFollowZoom)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineFreeLook)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineMixingCamera)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachinePath)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachinePipeline)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachinePixelPerfect)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineSmoothPath)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineStateDrivenCamera)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineStoryboard)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineTargetGroup)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineVirtualCamera)] = new Dictionary<string, string> {
				["get_Description"] = "CinemachineCinemachineVirtualCamera.__get_Description__SystemString",
				["get_name"] = "CinemachineCinemachineVirtualCamera.__get_name__SystemString",
				["set_name"] = "CinemachineCinemachineVirtualCamera.__set_name__SystemString__SystemVoid",
				["MoveToTopOfPrioritySubqueue"] = "CinemachineCinemachineVirtualCamera.__MoveToTopOfPrioritySubqueue__SystemVoid",
			},
			[typeof(global::Cinemachine.Cinemachine3rdPersonFollow)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineBasicMultiChannelPerlin)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineComposer)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineFramingTransposer)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineGroupComposer)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineHardLockToTarget)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineHardLookAt)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineOrbitalTransposer)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachinePOV)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineSameAsFollowTarget)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineTrackedDolly)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineTransposer)] = new Dictionary<string, string> {
			},
			[typeof(global::Cinemachine.CinemachineCore)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.SDK3.Video.Components.Base.BaseVRCVideoPlayer)] = new Dictionary<string, string> {
				["get_name"] = "VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer.__get_name__SystemString",
				["set_name"] = "VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer.__set_name__SystemString__SystemVoid",
				["Play"] = "VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer.__Play__SystemVoid",
				["Pause"] = "VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer.__Pause__SystemVoid",
				["Stop"] = "VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer.__Stop__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Video.Components.AVPro.VRCAVProVideoScreen)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.SDK3.Video.Components.AVPro.VRCAVProVideoSpeaker)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.SDK3.Midi.VRCMidiPlayer)] = new Dictionary<string, string> {
				["Play"] = "VRCSDK3MidiVRCMidiPlayer.__Play__SystemVoid",
				["Stop"] = "VRCSDK3MidiVRCMidiPlayer.__Stop__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Midi.VRCMidiListener)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCSpatialAudioSource)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCObjectPool)] = new Dictionary<string, string> {
				["get_name"] = "VRCSDK3ComponentsVRCObjectPool.__get_name__SystemString",
				["set_name"] = "VRCSDK3ComponentsVRCObjectPool.__set_name__SystemString__SystemVoid",
				["Shuffle"] = "VRCSDK3ComponentsVRCObjectPool.__Shuffle__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Components.VRCVisualDamage)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCAvatarPedestal)] = new Dictionary<string, string> {
				["get_name"] = "VRCSDK3ComponentsVRCAvatarPedestal.__get_name__SystemString",
				["set_name"] = "VRCSDK3ComponentsVRCAvatarPedestal.__set_name__SystemString__SystemVoid",
				["SwitchAvatar"] = "VRCSDK3ComponentsVRCAvatarPedestal.__SwitchAvatar__SystemString__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Components.VRCObjectSync)] = new Dictionary<string, string> {
				["get_name"] = "VRCSDK3ComponentsVRCObjectSync.__get_name__SystemString",
				["set_name"] = "VRCSDK3ComponentsVRCObjectSync.__set_name__SystemString__SystemVoid",
				["FlagDiscontinuity"] = "VRCSDK3ComponentsVRCObjectSync.__FlagDiscontinuity__SystemVoid",
				["Respawn"] = "VRCSDK3ComponentsVRCObjectSync.__Respawn__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Components.VRCPickup)] = new Dictionary<string, string> {
				["get_name"] = "VRCSDK3ComponentsVRCPickup.__get_name__SystemString",
				["set_name"] = "VRCSDK3ComponentsVRCPickup.__set_name__SystemString__SystemVoid",
				["Drop"] = "VRCSDK3ComponentsVRCPickup.__Drop__SystemVoid",
				["PlayHaptics"] = "VRCSDK3ComponentsVRCPickup.__PlayHaptics__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Components.VRCPortalMarker)] = new Dictionary<string, string> {
				["get_name"] = "VRCSDK3ComponentsVRCPortalMarker.__get_name__SystemString",
				["set_name"] = "VRCSDK3ComponentsVRCPortalMarker.__set_name__SystemString__SystemVoid",
				["RefreshPortal"] = "VRCSDK3ComponentsVRCPortalMarker.__RefreshPortal__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Components.VRCMirrorReflection)] = new Dictionary<string, string> {
				["get_name"] = "VRCSDK3ComponentsVRCMirrorReflection.__get_name__SystemString",
				["set_name"] = "VRCSDK3ComponentsVRCMirrorReflection.__set_name__SystemString__SystemVoid",
				["OnWillRenderObject"] = "VRCSDK3ComponentsVRCMirrorReflection.__OnWillRenderObject__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Components.VRCSceneDescriptor)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCStation)] = new Dictionary<string, string> {
				["get_name"] = "VRCSDK3ComponentsVRCStation.__get_name__SystemString",
				["set_name"] = "VRCSDK3ComponentsVRCStation.__set_name__SystemString__SystemVoid",
			},
			[typeof(global::VRC.SDK3.Components.VRCInputFieldKeyboardOverride)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.SDK3.Components.VRCUiShape)] = new Dictionary<string, string> {
			},
			[typeof(global::VRCProjectSettings)] = new Dictionary<string, string> {
			},
			[typeof(global::VRC.Core.PipelineManager)] = new Dictionary<string, string> {
			},
		};
	}
}


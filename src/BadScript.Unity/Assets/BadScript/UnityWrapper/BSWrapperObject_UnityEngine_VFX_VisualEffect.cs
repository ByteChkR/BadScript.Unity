using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.VFX;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_VFX_VisualEffect : BSWrapperObject < VisualEffect >

    {
        #region Public

        public BSWrapperObject_UnityEngine_VFX_VisualEffect( VisualEffect obj ) : base( obj )
        {
            m_Properties["pause"] = new BSReflectionReference(
                () => m_InternalObject.pause ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.pause = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["playRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.playRate ),
                x => m_InternalObject.playRate = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["startSeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startSeed ),
                x => m_InternalObject.startSeed = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["resetSeedOnPlay"] = new BSReflectionReference(
                () => m_InternalObject.resetSeedOnPlay ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.resetSeedOnPlay = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["initialEventID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.initialEventID ),
                x => m_InternalObject.initialEventID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["initialEventName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.initialEventName ),
                x => m_InternalObject.initialEventName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["culled"] = new BSReflectionReference(
                () => m_InternalObject.culled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["visualEffectAsset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_VFX_VisualEffectAsset( m_InternalObject.visualEffectAsset ),
                x => m_InternalObject.visualEffectAsset = WrapperHelper.UnwrapObject < VisualEffectAsset >( x ) );

            m_Properties["aliveParticleCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.aliveParticleCount ),
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["HasBool"] = new BSFunctionReference(
                new BSFunction(
                    "function HasBool(nameID)",
                    a => m_InternalObject.HasBool( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasInt"] = new BSFunctionReference(
                new BSFunction(
                    "function HasInt(nameID)",
                    a => m_InternalObject.HasInt( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasUInt"] = new BSFunctionReference(
                new BSFunction(
                    "function HasUInt(nameID)",
                    a => m_InternalObject.HasUInt( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function HasFloat(nameID)",
                    a => m_InternalObject.HasFloat( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector2"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector2(nameID)",
                    a => m_InternalObject.HasVector2( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector3"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector3(nameID)",
                    a => m_InternalObject.HasVector3( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector4"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector4(nameID)",
                    a => m_InternalObject.HasVector4( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasMatrix4x4"] = new BSFunctionReference(
                new BSFunction(
                    "function HasMatrix4x4(nameID)",
                    a => m_InternalObject.HasMatrix4x4( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function HasTexture(nameID)",
                    a => m_InternalObject.HasTexture( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasAnimationCurve"] = new BSFunctionReference(
                new BSFunction(
                    "function HasAnimationCurve(nameID)",
                    a => m_InternalObject.HasAnimationCurve( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasGradient"] = new BSFunctionReference(
                new BSFunction(
                    "function HasGradient(nameID)",
                    a => m_InternalObject.HasGradient( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function HasMesh(nameID)",
                    a => m_InternalObject.HasMesh( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(nameID)",
                    a => m_InternalObject.GetBool( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUInt(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUInt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector2"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector2(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetVector2( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector3"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector3(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetVector3( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector4"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector4(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetVector4( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMatrix4x4"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMatrix4x4(nameID)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetMatrix4x4( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(nameID)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        m_InternalObject.GetTexture( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMesh(nameID)",
                    a => new BSWrapperObject_UnityEngine_Mesh(
                        m_InternalObject.GetMesh( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetGradient"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGradient(nameID)",
                    a => new BSWrapperObject_UnityEngine_Gradient(
                        m_InternalObject.GetGradient( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAnimationCurve"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAnimationCurve(nameID)",
                    a => new BSWrapperObject_UnityEngine_AnimationCurve(
                        m_InternalObject.GetAnimationCurve( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["HasSystem"] = new BSFunctionReference(
                new BSFunction(
                    "function HasSystem(nameID)",
                    a => m_InternalObject.HasSystem( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetParticleSystemInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetParticleSystemInfo(nameID)",
                    a => new BSWrapperObject_UnityEngine_VFX_VFXParticleSystemInfo(
                        m_InternalObject.GetParticleSystemInfo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSpawnSystemInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSpawnSystemInfo(nameID)",
                    a => new BSWrapperObject_UnityEngine_VFX_VFXSpawnerState(
                        m_InternalObject.GetSpawnSystemInfo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["HasInt"] = new BSFunctionReference(
                new BSFunction(
                    "function HasInt(name)",
                    a => m_InternalObject.HasInt( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasUInt"] = new BSFunctionReference(
                new BSFunction(
                    "function HasUInt(name)",
                    a => m_InternalObject.HasUInt( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function HasFloat(name)",
                    a => m_InternalObject.HasFloat( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector2"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector2(name)",
                    a => m_InternalObject.HasVector2( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector3"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector3(name)",
                    a => m_InternalObject.HasVector3( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector4"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector4(name)",
                    a => m_InternalObject.HasVector4( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasMatrix4x4"] = new BSFunctionReference(
                new BSFunction(
                    "function HasMatrix4x4(name)",
                    a => m_InternalObject.HasMatrix4x4( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function HasTexture(name)",
                    a => m_InternalObject.HasTexture( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasAnimationCurve"] = new BSFunctionReference(
                new BSFunction(
                    "function HasAnimationCurve(name)",
                    a => m_InternalObject.HasAnimationCurve( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasGradient"] = new BSFunctionReference(
                new BSFunction(
                    "function HasGradient(name)",
                    a => m_InternalObject.HasGradient( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function HasMesh(name)",
                    a => m_InternalObject.HasMesh( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasBool"] = new BSFunctionReference(
                new BSFunction(
                    "function HasBool(name)",
                    a => m_InternalObject.HasBool( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUInt(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector2"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector2(name)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetVector2( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector3"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector3(name)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetVector3( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector4"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector4(name)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetVector4( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMatrix4x4"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMatrix4x4(name)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetMatrix4x4( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(name)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        m_InternalObject.GetTexture( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMesh(name)",
                    a => new BSWrapperObject_UnityEngine_Mesh(
                        m_InternalObject.GetMesh( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(name)",
                    a => m_InternalObject.GetBool( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetAnimationCurve"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAnimationCurve(name)",
                    a => new BSWrapperObject_UnityEngine_AnimationCurve(
                        m_InternalObject.GetAnimationCurve( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetGradient"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGradient(name)",
                    a => new BSWrapperObject_UnityEngine_Gradient(
                        m_InternalObject.GetGradient( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["HasSystem"] = new BSFunctionReference(
                new BSFunction(
                    "function HasSystem(name)",
                    a => m_InternalObject.HasSystem( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetParticleSystemInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetParticleSystemInfo(name)",
                    a => new BSWrapperObject_UnityEngine_VFX_VFXParticleSystemInfo(
                        m_InternalObject.GetParticleSystemInfo( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSpawnSystemInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSpawnSystemInfo(name)",
                    a => new BSWrapperObject_UnityEngine_VFX_VFXSpawnerState(
                        m_InternalObject.GetSpawnSystemInfo( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

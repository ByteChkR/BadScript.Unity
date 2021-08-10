using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AudioReverbZone : BSWrapperObject < AudioReverbZone >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AudioReverbZone( AudioReverbZone obj ) : base( obj )
        {
            m_Properties["minDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minDistance ),
                x => m_InternalObject.minDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxDistance ),
                x => m_InternalObject.maxDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["room"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.room ),
                x => m_InternalObject.room = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["roomHF"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.roomHF ),
                x => m_InternalObject.roomHF = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["roomLF"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.roomLF ),
                x => m_InternalObject.roomLF = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["decayTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.decayTime ),
                x => m_InternalObject.decayTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["decayHFRatio"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.decayHFRatio ),
                x => m_InternalObject.decayHFRatio = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["reflections"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.reflections ),
                x => m_InternalObject.reflections = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["reflectionsDelay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.reflectionsDelay ),
                x => m_InternalObject.reflectionsDelay = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["reverb"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.reverb ),
                x => m_InternalObject.reverb = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["reverbDelay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.reverbDelay ),
                x => m_InternalObject.reverbDelay = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["HFReference"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.HFReference ),
                x => m_InternalObject.HFReference = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["LFReference"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.LFReference ),
                x => m_InternalObject.LFReference = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["roomRolloffFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.roomRolloffFactor ),
                x => m_InternalObject.roomRolloffFactor = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["diffusion"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.diffusion ),
                x => m_InternalObject.diffusion = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["density"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.density ),
                x => m_InternalObject.density = WrapperHelper.UnwrapObject < float >( x ) );

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

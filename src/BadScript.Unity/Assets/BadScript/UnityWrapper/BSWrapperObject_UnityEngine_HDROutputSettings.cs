using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_HDROutputSettings : BSWrapperObject < HDROutputSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_HDROutputSettings( HDROutputSettings obj ) : base( obj )
        {
            m_Properties["active"] = new BSReflectionReference(
                () => m_InternalObject.active ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["available"] = new BSReflectionReference(
                () => m_InternalObject.available ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["automaticHDRTonemapping"] = new BSReflectionReference(
                () => m_InternalObject.automaticHDRTonemapping ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.automaticHDRTonemapping = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["paperWhiteNits"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.paperWhiteNits ),
                x => m_InternalObject.paperWhiteNits = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxFullFrameToneMapLuminance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxFullFrameToneMapLuminance ),
                null );

            m_Properties["maxToneMapLuminance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxToneMapLuminance ),
                null );

            m_Properties["minToneMapLuminance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minToneMapLuminance ),
                null );

            m_Properties["HDRModeChangeRequested"] = new BSReflectionReference(
                () => m_InternalObject.HDRModeChangeRequested ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

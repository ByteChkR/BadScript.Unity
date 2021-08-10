using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_XR_XRDisplaySubsystemDescriptor : BSWrapperObject < XRDisplaySubsystemDescriptor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_XRDisplaySubsystemDescriptor( XRDisplaySubsystemDescriptor obj ) : base(
            obj )
        {
            m_Properties["disablesLegacyVr"] = new BSReflectionReference(
                () => m_InternalObject.disablesLegacyVr ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["enableBackBufferMSAA"] = new BSReflectionReference(
                () => m_InternalObject.enableBackBufferMSAA ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["id"] = new BSReflectionReference( () => new BSObject( m_InternalObject.id ), null );

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

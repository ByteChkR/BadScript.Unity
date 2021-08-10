using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_XR_XRInputSubsystemDescriptor : BSWrapperObject < XRInputSubsystemDescriptor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_XRInputSubsystemDescriptor( XRInputSubsystemDescriptor obj ) : base( obj )
        {
            m_Properties["disablesLegacyInput"] = new BSReflectionReference(
                () => m_InternalObject.disablesLegacyInput ? BSObject.One : BSObject.Zero,
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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_XR_InputDevice : BSWrapperObject < InputDevice >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_InputDevice( InputDevice obj ) : base( obj )
        {
            m_Properties["subsystem"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_XR_XRInputSubsystem( m_InternalObject.subsystem ),
                null );

            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.name ), null );

            m_Properties["manufacturer"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.manufacturer ),
                null );

            m_Properties["serialNumber"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.serialNumber ),
                null );

            m_Properties["SendHapticImpulse"] = new BSFunctionReference(
                new BSFunction(
                    "function SendHapticImpulse(channel, amplitude, duration)",
                    a => m_InternalObject.SendHapticImpulse(
                        WrapperHelper.UnwrapObject < uint >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < InputDevice >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

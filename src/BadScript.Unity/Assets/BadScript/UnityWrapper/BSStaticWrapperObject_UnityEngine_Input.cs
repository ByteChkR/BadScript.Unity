using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Input : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Input() : base( typeof( Input ) )
        {
            m_StaticProperties["simulateMouseWithTouches"] = new BSReflectionReference(
                () => Input.simulateMouseWithTouches ? BSObject.One : BSObject.Zero,
                x => Input.simulateMouseWithTouches = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["anyKey"] = new BSReflectionReference(
                () => Input.anyKey ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["anyKeyDown"] = new BSReflectionReference(
                () => Input.anyKeyDown ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["inputString"] =
                new BSReflectionReference( () => new BSObject( Input.inputString ), null );

            m_StaticProperties["mousePosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( Input.mousePosition ),
                null );

            m_StaticProperties["mouseScrollDelta"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Input.mouseScrollDelta ),
                null );

            m_StaticProperties["compositionString"] = new BSReflectionReference(
                () => new BSObject( Input.compositionString ),
                null );

            m_StaticProperties["imeIsSelected"] = new BSReflectionReference(
                () => Input.imeIsSelected ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["compositionCursorPos"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Input.compositionCursorPos ),
                x => Input.compositionCursorPos = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_StaticProperties["eatKeyPressOnTextFieldFocus"] = new BSReflectionReference(
                () => Input.eatKeyPressOnTextFieldFocus ? BSObject.One : BSObject.Zero,
                x => Input.eatKeyPressOnTextFieldFocus = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["mousePresent"] = new BSReflectionReference(
                () => Input.mousePresent ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["touchCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Input.touchCount ),
                null );

            m_StaticProperties["touchPressureSupported"] = new BSReflectionReference(
                () => Input.touchPressureSupported ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["stylusTouchSupported"] = new BSReflectionReference(
                () => Input.stylusTouchSupported ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["touchSupported"] = new BSReflectionReference(
                () => Input.touchSupported ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["multiTouchEnabled"] = new BSReflectionReference(
                () => Input.multiTouchEnabled ? BSObject.One : BSObject.Zero,
                x => Input.multiTouchEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["isGyroAvailable"] = new BSReflectionReference(
                () => Input.isGyroAvailable ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["acceleration"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( Input.acceleration ),
                null );

            m_StaticProperties["compensateSensors"] = new BSReflectionReference(
                () => Input.compensateSensors ? BSObject.One : BSObject.Zero,
                x => Input.compensateSensors = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["accelerationEventCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Input.accelerationEventCount ),
                null );

            m_StaticProperties["backButtonLeavesApp"] = new BSReflectionReference(
                () => Input.backButtonLeavesApp ? BSObject.One : BSObject.Zero,
                x => Input.backButtonLeavesApp = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["location"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_LocationService( Input.location ),
                null );

            m_StaticProperties["compass"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Compass( Input.compass ),
                null );

            m_StaticProperties["gyro"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Gyroscope( Input.gyro ),
                null );

            m_StaticProperties["GetAxis"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAxis(axisName)",
                    a => new BSObject( ( decimal ) Input.GetAxis( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAxisRaw"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAxisRaw(axisName)",
                    a => new BSObject( ( decimal ) Input.GetAxisRaw( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetButton"] = new BSFunctionReference(
                new BSFunction(
                    "function GetButton(buttonName)",
                    a => Input.GetButton( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetButtonDown"] = new BSFunctionReference(
                new BSFunction(
                    "function GetButtonDown(buttonName)",
                    a => Input.GetButtonDown( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetButtonUp"] = new BSFunctionReference(
                new BSFunction(
                    "function GetButtonUp(buttonName)",
                    a => Input.GetButtonUp( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetMouseButton"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButton(button)",
                    a => Input.GetMouseButton( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetMouseButtonDown"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButtonDown(button)",
                    a => Input.GetMouseButtonDown( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetMouseButtonUp"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButtonUp(button)",
                    a => Input.GetMouseButtonUp( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsJoystickPreconfigured"] = new BSFunctionReference(
                new BSFunction(
                    "function IsJoystickPreconfigured(joystickName)",
                    a => Input.IsJoystickPreconfigured( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetTouch"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTouch(index)",
                    a => new BSWrapperObject_UnityEngine_Touch(
                        Input.GetTouch( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAccelerationEvent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAccelerationEvent(index)",
                    a => new BSWrapperObject_UnityEngine_AccelerationEvent(
                        Input.GetAccelerationEvent( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetKey"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKey(name)",
                    a => Input.GetKey( WrapperHelper.UnwrapObject < string >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetKeyUp"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKeyUp(name)",
                    a => Input.GetKeyUp( WrapperHelper.UnwrapObject < string >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetKeyDown"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKeyDown(name)",
                    a => Input.GetKeyDown( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

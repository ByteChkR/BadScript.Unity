using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Input : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Input() : base(typeof(UnityEngine.Input))
        {
            m_StaticProperties["simulateMouseWithTouches"] = new BSReflectionReference(() => UnityEngine.Input.simulateMouseWithTouches ? BSObject.One : BSObject.Zero, x=> UnityEngine.Input.simulateMouseWithTouches = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["anyKey"] = new BSReflectionReference(() => UnityEngine.Input.anyKey ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["anyKeyDown"] = new BSReflectionReference(() => UnityEngine.Input.anyKeyDown ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["inputString"] = new BSReflectionReference(() => new BSObject(UnityEngine.Input.inputString), null);
            m_StaticProperties["mousePosition"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Input.mousePosition), null);
            m_StaticProperties["mouseScrollDelta"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(UnityEngine.Input.mouseScrollDelta), null);
            m_StaticProperties["compositionString"] = new BSReflectionReference(() => new BSObject(UnityEngine.Input.compositionString), null);
            m_StaticProperties["imeIsSelected"] = new BSReflectionReference(() => UnityEngine.Input.imeIsSelected ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["compositionCursorPos"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(UnityEngine.Input.compositionCursorPos), x=> UnityEngine.Input.compositionCursorPos = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_StaticProperties["eatKeyPressOnTextFieldFocus"] = new BSReflectionReference(() => UnityEngine.Input.eatKeyPressOnTextFieldFocus ? BSObject.One : BSObject.Zero, x=> UnityEngine.Input.eatKeyPressOnTextFieldFocus = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["mousePresent"] = new BSReflectionReference(() => UnityEngine.Input.mousePresent ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["touchCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Input.touchCount), null);
            m_StaticProperties["touchPressureSupported"] = new BSReflectionReference(() => UnityEngine.Input.touchPressureSupported ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["stylusTouchSupported"] = new BSReflectionReference(() => UnityEngine.Input.stylusTouchSupported ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["touchSupported"] = new BSReflectionReference(() => UnityEngine.Input.touchSupported ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["multiTouchEnabled"] = new BSReflectionReference(() => UnityEngine.Input.multiTouchEnabled ? BSObject.One : BSObject.Zero, x=> UnityEngine.Input.multiTouchEnabled = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["isGyroAvailable"] = new BSReflectionReference(() => UnityEngine.Input.isGyroAvailable ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["acceleration"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Input.acceleration), null);
            m_StaticProperties["compensateSensors"] = new BSReflectionReference(() => UnityEngine.Input.compensateSensors ? BSObject.One : BSObject.Zero, x=> UnityEngine.Input.compensateSensors = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["accelerationEventCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Input.accelerationEventCount), null);
            m_StaticProperties["backButtonLeavesApp"] = new BSReflectionReference(() => UnityEngine.Input.backButtonLeavesApp ? BSObject.One : BSObject.Zero, x=> UnityEngine.Input.backButtonLeavesApp = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["location"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_LocationService(UnityEngine.Input.location), null);
            m_StaticProperties["compass"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Compass(UnityEngine.Input.compass), null);
            m_StaticProperties["gyro"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Gyroscope(UnityEngine.Input.gyro), null);
            m_StaticProperties["GetAxis"] = new BSFunctionReference(new BSFunction("function GetAxis(axisName)", a => new BSObject((decimal)UnityEngine.Input.GetAxis(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetAxisRaw"] = new BSFunctionReference(new BSFunction("function GetAxisRaw(axisName)", a => new BSObject((decimal)UnityEngine.Input.GetAxisRaw(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetButton"] = new BSFunctionReference(new BSFunction("function GetButton(buttonName)", a => UnityEngine.Input.GetButton(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetButtonDown"] = new BSFunctionReference(new BSFunction("function GetButtonDown(buttonName)", a => UnityEngine.Input.GetButtonDown(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetButtonUp"] = new BSFunctionReference(new BSFunction("function GetButtonUp(buttonName)", a => UnityEngine.Input.GetButtonUp(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetMouseButton"] = new BSFunctionReference(new BSFunction("function GetMouseButton(button)", a => UnityEngine.Input.GetMouseButton(WrapperHelper.UnwrapObject<System.Int32>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetMouseButtonDown"] = new BSFunctionReference(new BSFunction("function GetMouseButtonDown(button)", a => UnityEngine.Input.GetMouseButtonDown(WrapperHelper.UnwrapObject<System.Int32>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetMouseButtonUp"] = new BSFunctionReference(new BSFunction("function GetMouseButtonUp(button)", a => UnityEngine.Input.GetMouseButtonUp(WrapperHelper.UnwrapObject<System.Int32>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["ResetInputAxes"] = new BSFunctionReference(new BSFunction("function ResetInputAxes()", a => {
                UnityEngine.Input.ResetInputAxes();
                return new BSObject(null);
            }, 0));
            m_StaticProperties["IsJoystickPreconfigured"] = new BSFunctionReference(new BSFunction("function IsJoystickPreconfigured(joystickName)", a => UnityEngine.Input.IsJoystickPreconfigured(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetTouch"] = new BSFunctionReference(new BSFunction("function GetTouch(index)", a => new BSWrapperObject_UnityEngine_Touch(UnityEngine.Input.GetTouch(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetAccelerationEvent"] = new BSFunctionReference(new BSFunction("function GetAccelerationEvent(index)", a => new BSWrapperObject_UnityEngine_AccelerationEvent(UnityEngine.Input.GetAccelerationEvent(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetKey"] = new BSFunctionReference(new BSFunction("function GetKey(name)", a => UnityEngine.Input.GetKey(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetKeyUp"] = new BSFunctionReference(new BSFunction("function GetKeyUp(name)", a => UnityEngine.Input.GetKeyUp(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetKeyDown"] = new BSFunctionReference(new BSFunction("function GetKeyDown(name)", a => UnityEngine.Input.GetKeyDown(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));

        }
    }

}
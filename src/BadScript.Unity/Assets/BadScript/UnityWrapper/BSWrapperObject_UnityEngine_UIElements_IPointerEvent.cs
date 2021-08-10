using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_IPointerEvent : BSWrapperObject < IPointerEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IPointerEvent( IPointerEvent obj ) : base( obj )
        {
            m_Properties["pointerId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pointerId ),
                null );

            m_Properties["pointerType"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.pointerType ),
                null );

            m_Properties["isPrimary"] = new BSReflectionReference(
                () => m_InternalObject.isPrimary ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["button"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.button ),
                null );

            m_Properties["pressedButtons"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pressedButtons ),
                null );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                null );

            m_Properties["localPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.localPosition ),
                null );

            m_Properties["deltaPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.deltaPosition ),
                null );

            m_Properties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.deltaTime ),
                null );

            m_Properties["clickCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clickCount ),
                null );

            m_Properties["pressure"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pressure ),
                null );

            m_Properties["tangentialPressure"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tangentialPressure ),
                null );

            m_Properties["altitudeAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.altitudeAngle ),
                null );

            m_Properties["azimuthAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.azimuthAngle ),
                null );

            m_Properties["twist"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.twist ),
                null );

            m_Properties["radius"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.radius ),
                null );

            m_Properties["radiusVariance"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.radiusVariance ),
                null );

            m_Properties["shiftKey"] = new BSReflectionReference(
                () => m_InternalObject.shiftKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ctrlKey"] = new BSReflectionReference(
                () => m_InternalObject.ctrlKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["commandKey"] = new BSReflectionReference(
                () => m_InternalObject.commandKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["altKey"] = new BSReflectionReference(
                () => m_InternalObject.altKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["actionKey"] = new BSReflectionReference(
                () => m_InternalObject.actionKey ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

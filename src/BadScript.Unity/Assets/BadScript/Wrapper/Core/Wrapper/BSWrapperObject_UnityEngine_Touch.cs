using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Touch : BSWrapperObject<UnityEngine.Touch>

    {
        public BSWrapperObject_UnityEngine_Touch(UnityEngine.Touch obj) : base(obj)
        {
            m_Properties["fingerId"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.fingerId), x=> m_InternalObject.fingerId = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["position"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.position), x=> m_InternalObject.position = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["rawPosition"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.rawPosition), x=> m_InternalObject.rawPosition = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["deltaPosition"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.deltaPosition), x=> m_InternalObject.deltaPosition = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["deltaTime"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.deltaTime), x=> m_InternalObject.deltaTime = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["tapCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.tapCount), x=> m_InternalObject.tapCount = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["pressure"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.pressure), x=> m_InternalObject.pressure = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["maximumPossiblePressure"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.maximumPossiblePressure), x=> m_InternalObject.maximumPossiblePressure = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["altitudeAngle"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.altitudeAngle), x=> m_InternalObject.altitudeAngle = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["azimuthAngle"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.azimuthAngle), x=> m_InternalObject.azimuthAngle = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["radius"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.radius), x=> m_InternalObject.radius = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["radiusVariance"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.radiusVariance), x=> m_InternalObject.radiusVariance = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
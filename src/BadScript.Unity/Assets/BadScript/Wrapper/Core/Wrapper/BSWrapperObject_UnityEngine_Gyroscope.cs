using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Gyroscope : BSWrapperObject<UnityEngine.Gyroscope>

    {
        public BSWrapperObject_UnityEngine_Gyroscope(UnityEngine.Gyroscope obj) : base(obj)
        {
            m_Properties["rotationRate"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.rotationRate), null);
            m_Properties["rotationRateUnbiased"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.rotationRateUnbiased), null);
            m_Properties["gravity"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.gravity), null);
            m_Properties["userAcceleration"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.userAcceleration), null);
            m_Properties["attitude"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Quaternion(m_InternalObject.attitude), null);
            m_Properties["enabled"] = new BSReflectionReference(() => m_InternalObject.enabled ? BSObject.One : BSObject.Zero, x=> m_InternalObject.enabled = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["updateInterval"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.updateInterval), x=> m_InternalObject.updateInterval = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
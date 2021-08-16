using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_FrustumPlanes : BSWrapperObject<UnityEngine.FrustumPlanes>

    {
        public BSWrapperObject_UnityEngine_FrustumPlanes(UnityEngine.FrustumPlanes obj) : base(obj)
        {
            m_Properties["left"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.left), x=> m_InternalObject.left = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["right"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.right), x=> m_InternalObject.right = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["bottom"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.bottom), x=> m_InternalObject.bottom = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["top"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.top), x=> m_InternalObject.top = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["zNear"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.zNear), x=> m_InternalObject.zNear = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["zFar"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.zFar), x=> m_InternalObject.zFar = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
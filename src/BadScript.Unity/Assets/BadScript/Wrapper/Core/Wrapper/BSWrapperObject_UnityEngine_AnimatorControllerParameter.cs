using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_AnimatorControllerParameter : BSWrapperObject<UnityEngine.AnimatorControllerParameter>

    {
        public BSWrapperObject_UnityEngine_AnimatorControllerParameter(UnityEngine.AnimatorControllerParameter obj) : base(obj)
        {
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["nameHash"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.nameHash), null);
            m_Properties["defaultFloat"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.defaultFloat), x=> m_InternalObject.defaultFloat = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["defaultInt"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.defaultInt), x=> m_InternalObject.defaultInt = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["defaultBool"] = new BSReflectionReference(() => m_InternalObject.defaultBool ? BSObject.One : BSObject.Zero, x=> m_InternalObject.defaultBool = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(o)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
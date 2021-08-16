using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Avatar : BSWrapperObject<UnityEngine.Avatar>

    {
        public BSWrapperObject_UnityEngine_Avatar(UnityEngine.Avatar obj) : base(obj)
        {
            m_Properties["isValid"] = new BSReflectionReference(() => m_InternalObject.isValid ? BSObject.One : BSObject.Zero, null);
            m_Properties["isHuman"] = new BSReflectionReference(() => m_InternalObject.isHuman ? BSObject.One : BSObject.Zero, null);
            m_Properties["humanDescription"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_HumanDescription(m_InternalObject.humanDescription), null);
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
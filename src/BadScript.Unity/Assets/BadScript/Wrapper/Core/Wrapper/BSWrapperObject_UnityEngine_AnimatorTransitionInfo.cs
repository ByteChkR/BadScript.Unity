using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_AnimatorTransitionInfo : BSWrapperObject<UnityEngine.AnimatorTransitionInfo>

    {
        public BSWrapperObject_UnityEngine_AnimatorTransitionInfo(UnityEngine.AnimatorTransitionInfo obj) : base(obj)
        {
            m_Properties["fullPathHash"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.fullPathHash), null);
            m_Properties["nameHash"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.nameHash), null);
            m_Properties["userNameHash"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.userNameHash), null);
            m_Properties["duration"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.duration), null);
            m_Properties["normalizedTime"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.normalizedTime), null);
            m_Properties["anyState"] = new BSReflectionReference(() => m_InternalObject.anyState ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsName"] = new BSFunctionReference(new BSFunction("function IsName(name)", a => m_InternalObject.IsName(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["IsUserName"] = new BSFunctionReference(new BSFunction("function IsUserName(name)", a => m_InternalObject.IsUserName(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
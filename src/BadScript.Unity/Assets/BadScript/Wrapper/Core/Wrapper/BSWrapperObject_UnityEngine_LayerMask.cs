using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_LayerMask : BSWrapperObject<UnityEngine.LayerMask>

    {
        public BSWrapperObject_UnityEngine_LayerMask(UnityEngine.LayerMask obj) : base(obj)
        {
            m_Properties["value"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.value), x=> m_InternalObject.value = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
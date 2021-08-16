using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_IntPtr : BSWrapperObject<System.IntPtr>

    {
        public BSWrapperObject_System_IntPtr(System.IntPtr obj) : base(obj)
        {
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToInt32"] = new BSFunctionReference(new BSFunction("function ToInt32()", a => new BSObject((decimal)m_InternalObject.ToInt32()), 0));
            m_Properties["ToInt64"] = new BSFunctionReference(new BSFunction("function ToInt64()", a => new BSObject((decimal)m_InternalObject.ToInt64()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
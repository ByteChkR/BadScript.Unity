using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Guid : BSWrapperObject<System.Guid>

    {
        public BSWrapperObject_System_Guid(System.Guid obj) : base(obj)
        {
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(o)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(g)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Guid>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["CompareTo"] = new BSFunctionReference(new BSFunction("function CompareTo(value)", a => new BSObject((decimal)m_InternalObject.CompareTo(WrapperHelper.UnwrapObject<System.Object>(a[0]))), 1));
            m_Properties["CompareTo"] = new BSFunctionReference(new BSFunction("function CompareTo(value)", a => new BSObject((decimal)m_InternalObject.CompareTo(WrapperHelper.UnwrapObject<System.Guid>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, provider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));

        }
    }

}
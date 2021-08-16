using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Version : BSWrapperObject<System.Version>

    {
        public BSWrapperObject_System_Version(System.Version obj) : base(obj)
        {
            m_Properties["Major"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Major), null);
            m_Properties["Minor"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Minor), null);
            m_Properties["Build"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Build), null);
            m_Properties["Revision"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Revision), null);
            m_Properties["MajorRevision"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.MajorRevision), null);
            m_Properties["MinorRevision"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.MinorRevision), null);
            m_Properties["Clone"] = new BSFunctionReference(new BSFunction("function Clone()", a => new BSWrapperObject_System_Object(m_InternalObject.Clone()), 0));
            m_Properties["CompareTo"] = new BSFunctionReference(new BSFunction("function CompareTo(version)", a => new BSObject((decimal)m_InternalObject.CompareTo(WrapperHelper.UnwrapObject<System.Object>(a[0]))), 1));
            m_Properties["CompareTo"] = new BSFunctionReference(new BSFunction("function CompareTo(value)", a => new BSObject((decimal)m_InternalObject.CompareTo(WrapperHelper.UnwrapObject<System.Version>(a[0]))), 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Version>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(fieldCount)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));

        }
    }

}
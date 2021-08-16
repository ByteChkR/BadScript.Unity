using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Globalization_CompareInfo : BSWrapperObject<System.Globalization.CompareInfo>

    {
        public BSWrapperObject_System_Globalization_CompareInfo(System.Globalization.CompareInfo obj) : base(obj)
        {
            m_Properties["Name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.Name), null);
            m_Properties["LCID"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.LCID), null);
            m_Properties["Version"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_SortVersion(m_InternalObject.Version), null);
            m_Properties["Compare"] = new BSFunctionReference(new BSFunction("function Compare(string1, string2)", a => new BSObject((decimal)m_InternalObject.Compare(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]))), 2));
            m_Properties["Compare"] = new BSFunctionReference(new BSFunction("function Compare(string1, offset1, length1, string2, offset2, length2)", a => new BSObject((decimal)m_InternalObject.Compare(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.String>(a[3]), WrapperHelper.UnwrapObject<System.Int32>(a[4]), WrapperHelper.UnwrapObject<System.Int32>(a[5]))), 6));
            m_Properties["Compare"] = new BSFunctionReference(new BSFunction("function Compare(string1, offset1, string2, offset2)", a => new BSObject((decimal)m_InternalObject.Compare(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.String>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]))), 4));
            m_Properties["IsPrefix"] = new BSFunctionReference(new BSFunction("function IsPrefix(source, prefix)", a => m_InternalObject.IsPrefix(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["IsSuffix"] = new BSFunctionReference(new BSFunction("function IsSuffix(source, suffix)", a => m_InternalObject.IsSuffix(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(source, value)", a => new BSObject((decimal)m_InternalObject.IndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Char>(a[1]))), 2));
            m_Properties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(source, value)", a => new BSObject((decimal)m_InternalObject.IndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]))), 2));
            m_Properties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(source, value, startIndex)", a => new BSObject((decimal)m_InternalObject.IndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Char>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_Properties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(source, value, startIndex)", a => new BSObject((decimal)m_InternalObject.IndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_Properties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(source, value, startIndex, count)", a => new BSObject((decimal)m_InternalObject.IndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Char>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]))), 4));
            m_Properties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(source, value, startIndex, count)", a => new BSObject((decimal)m_InternalObject.IndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]))), 4));
            m_Properties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(source, value)", a => new BSObject((decimal)m_InternalObject.LastIndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Char>(a[1]))), 2));
            m_Properties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(source, value)", a => new BSObject((decimal)m_InternalObject.LastIndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]))), 2));
            m_Properties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(source, value, startIndex)", a => new BSObject((decimal)m_InternalObject.LastIndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Char>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_Properties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(source, value, startIndex)", a => new BSObject((decimal)m_InternalObject.LastIndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_Properties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(source, value, startIndex, count)", a => new BSObject((decimal)m_InternalObject.LastIndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Char>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]))), 4));
            m_Properties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(source, value, startIndex, count)", a => new BSObject((decimal)m_InternalObject.LastIndexOf(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]))), 4));
            m_Properties["GetSortKey"] = new BSFunctionReference(new BSFunction("function GetSortKey(source)", a => new BSWrapperObject_System_Globalization_SortKey(m_InternalObject.GetSortKey(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(value)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Globalization_CompareInfo : BSWrapperObject < CompareInfo >

    {
        #region Public

        public BSWrapperObject_System_Globalization_CompareInfo( CompareInfo obj ) : base( obj )
        {
            m_Properties["Name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Name ), null );

            m_Properties["LCID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.LCID ),
                null );

            m_Properties["Version"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_SortVersion( m_InternalObject.Version ),
                null );

            m_Properties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(string1, string2)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Compare(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_Properties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(string1, offset1, length1, string2, offset2, length2)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Compare(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < string >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) ) ),
                    6 ) );

            m_Properties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(string1, offset1, string2, offset2)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Compare(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_Properties["IsPrefix"] = new BSFunctionReference(
                new BSFunction(
                    "function IsPrefix(source, prefix)",
                    a => m_InternalObject.IsPrefix(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < string >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["IsSuffix"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSuffix(source, suffix)",
                    a => m_InternalObject.IsSuffix(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < string >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(source, value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ) ) ),
                    2 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(source, value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(source, value, startIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(source, value, startIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(source, value, startIndex, count)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(source, value, startIndex, count)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(source, value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ) ) ),
                    2 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(source, value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(source, value, startIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(source, value, startIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(source, value, startIndex, count)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(source, value, startIndex, count)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_Properties["GetSortKey"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSortKey(source)",
                    a => new BSWrapperObject_System_Globalization_SortKey(
                        m_InternalObject.GetSortKey( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(value)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

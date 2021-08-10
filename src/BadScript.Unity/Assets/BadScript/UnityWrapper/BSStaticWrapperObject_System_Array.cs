using System;
using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Array : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Array() : base( typeof( Array ) )
        {
            m_StaticProperties["BinarySearch"] = new BSFunctionReference(
                new BSFunction(
                    "function BinarySearch(array, value)",
                    a => new BSObject(
                        ( decimal ) Array.BinarySearch(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["BinarySearch"] = new BSFunctionReference(
                new BSFunction(
                    "function BinarySearch(array, index, length, value)",
                    a => new BSObject(
                        ( decimal ) Array.BinarySearch(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < object >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["BinarySearch"] = new BSFunctionReference(
                new BSFunction(
                    "function BinarySearch(array, value, comparer)",
                    a => new BSObject(
                        ( decimal ) Array.BinarySearch(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["BinarySearch"] = new BSFunctionReference(
                new BSFunction(
                    "function BinarySearch(array, index, length, value, comparer)",
                    a => new BSObject(
                        ( decimal ) Array.BinarySearch(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < object >( a[3] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(array, value)",
                    a => new BSObject(
                        ( decimal ) Array.IndexOf(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(array, value, startIndex)",
                    a => new BSObject(
                        ( decimal ) Array.IndexOf(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(array, value, startIndex, count)",
                    a => new BSObject(
                        ( decimal ) Array.IndexOf(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(array, value)",
                    a => new BSObject(
                        ( decimal ) Array.LastIndexOf(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(array, value, startIndex)",
                    a => new BSObject(
                        ( decimal ) Array.LastIndexOf(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(array, value, startIndex, count)",
                    a => new BSObject(
                        ( decimal ) Array.LastIndexOf(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

        }

        #endregion
    }

}

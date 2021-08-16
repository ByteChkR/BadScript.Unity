using System;
using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
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

            m_StaticProperties["Copy"] = new BSFunctionReference(
                new BSFunction(
                    "function Copy(sourceArray, destinationArray, length)",
                    a =>
                    {
                        Array.Copy(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ),
                            WrapperHelper.UnwrapObject < long >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["Copy"] = new BSFunctionReference(
                new BSFunction(
                    "function Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)",
                    a =>
                    {
                        Array.Copy(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < long >( a[1] ),
                            WrapperHelper.UnwrapObject < Array >( a[2] ),
                            WrapperHelper.UnwrapObject < long >( a[3] ),
                            WrapperHelper.UnwrapObject < long >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

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

            m_StaticProperties["Reverse"] = new BSFunctionReference(
                new BSFunction(
                    "function Reverse(array)",
                    a =>
                    {
                        Array.Reverse( WrapperHelper.UnwrapObject < Array >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["Reverse"] = new BSFunctionReference(
                new BSFunction(
                    "function Reverse(array, index, length)",
                    a =>
                    {
                        Array.Reverse(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(array)",
                    a =>
                    {
                        Array.Sort( WrapperHelper.UnwrapObject < Array >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(array, index, length)",
                    a =>
                    {
                        Array.Sort(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(array, comparer)",
                    a =>
                    {
                        Array.Sort(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(array, index, length, comparer)",
                    a =>
                    {
                        Array.Sort(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_StaticProperties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(keys, items)",
                    a =>
                    {
                        Array.Sort(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(keys, items, comparer)",
                    a =>
                    {
                        Array.Sort(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(keys, items, index, length)",
                    a =>
                    {
                        Array.Sort(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_StaticProperties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(keys, items, index, length, comparer)",
                    a =>
                    {
                        Array.Sort(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_StaticProperties["Clear"] = new BSFunctionReference(
                new BSFunction(
                    "function Clear(array, index, length)",
                    a =>
                    {
                        Array.Clear(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["Copy"] = new BSFunctionReference(
                new BSFunction(
                    "function Copy(sourceArray, destinationArray, length)",
                    a =>
                    {
                        Array.Copy(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["Copy"] = new BSFunctionReference(
                new BSFunction(
                    "function Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)",
                    a =>
                    {
                        Array.Copy(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Array >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_StaticProperties["ConstrainedCopy"] = new BSFunctionReference(
                new BSFunction(
                    "function ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)",
                    a =>
                    {
                        Array.ConstrainedCopy(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Array >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

        }

        #endregion
    }

}

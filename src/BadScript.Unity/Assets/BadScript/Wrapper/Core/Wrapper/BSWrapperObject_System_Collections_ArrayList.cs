using System;
using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_ArrayList : BSWrapperObject < ArrayList >

    {
        #region Public

        public BSWrapperObject_System_Collections_ArrayList( ArrayList obj ) : base( obj )
        {
            m_Properties["Capacity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Capacity ),
                x => m_InternalObject.Capacity = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Count"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Count ),
                null );

            m_Properties["IsFixedSize"] = new BSReflectionReference(
                () => m_InternalObject.IsFixedSize ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsReadOnly"] = new BSReflectionReference(
                () => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsSynchronized"] = new BSReflectionReference(
                () => m_InternalObject.IsSynchronized ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["SyncRoot"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.SyncRoot ),
                null );

            m_Properties["get_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function get_Item(index)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] ),
                    1 ) );

            m_Properties["set_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function set_Item(index, value)",
                    a =>
                    {
                        m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] =
                            WrapperHelper.UnwrapObject < object >( a[1] );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Add"] = new BSFunctionReference(
                new BSFunction(
                    "function Add(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Add( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddRange"] = new BSFunctionReference(
                new BSFunction(
                    "function AddRange(c)",
                    a =>
                    {
                        m_InternalObject.AddRange( WrapperHelper.UnwrapObject < ICollection >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["BinarySearch"] = new BSFunctionReference(
                new BSFunction(
                    "function BinarySearch(index, count, value, comparer)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BinarySearch(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < object >( a[2] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[3] ) ) ),
                    4 ) );

            m_Properties["BinarySearch"] = new BSFunctionReference(
                new BSFunction(
                    "function BinarySearch(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BinarySearch( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["BinarySearch"] = new BSFunctionReference(
                new BSFunction(
                    "function BinarySearch(value, comparer)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BinarySearch(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[1] ) ) ),
                    2 ) );

            m_Properties["Clear"] = new BSFunctionReference(
                new BSFunction(
                    "function Clear()",
                    a =>
                    {
                        m_InternalObject.Clear();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Clone"] = new BSFunctionReference(
                new BSFunction(
                    "function Clone()",
                    a => new BSWrapperObject_System_Object( m_InternalObject.Clone() ),
                    0 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(item)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["CopyTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyTo(array)",
                    a =>
                    {
                        m_InternalObject.CopyTo( WrapperHelper.UnwrapObject < Array >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["CopyTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyTo(array, arrayIndex)",
                    a =>
                    {
                        m_InternalObject.CopyTo(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["CopyTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyTo(index, array, arrayIndex, count)",
                    a =>
                    {
                        m_InternalObject.CopyTo(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["GetEnumerator"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEnumerator()",
                    a => new BSWrapperObject_System_Collections_IEnumerator( m_InternalObject.GetEnumerator() ),
                    0 ) );

            m_Properties["GetEnumerator"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEnumerator(index, count)",
                    a => new BSWrapperObject_System_Collections_IEnumerator(
                        m_InternalObject.GetEnumerator(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(value, startIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(value, startIndex, count)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["Insert"] = new BSFunctionReference(
                new BSFunction(
                    "function Insert(index, value)",
                    a =>
                    {
                        m_InternalObject.Insert(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["InsertRange"] = new BSFunctionReference(
                new BSFunction(
                    "function InsertRange(index, c)",
                    a =>
                    {
                        m_InternalObject.InsertRange(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ICollection >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(value, startIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["LastIndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function LastIndexOf(value, startIndex, count)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.LastIndexOf(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["Remove"] = new BSFunctionReference(
                new BSFunction(
                    "function Remove(obj)",
                    a =>
                    {
                        m_InternalObject.Remove( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["RemoveAt"] = new BSFunctionReference(
                new BSFunction(
                    "function RemoveAt(index)",
                    a =>
                    {
                        m_InternalObject.RemoveAt( WrapperHelper.UnwrapObject < int >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["RemoveRange"] = new BSFunctionReference(
                new BSFunction(
                    "function RemoveRange(index, count)",
                    a =>
                    {
                        m_InternalObject.RemoveRange(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Reverse"] = new BSFunctionReference(
                new BSFunction(
                    "function Reverse()",
                    a =>
                    {
                        m_InternalObject.Reverse();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Reverse"] = new BSFunctionReference(
                new BSFunction(
                    "function Reverse(index, count)",
                    a =>
                    {
                        m_InternalObject.Reverse(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetRange"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRange(index, c)",
                    a =>
                    {
                        m_InternalObject.SetRange(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ICollection >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["GetRange"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRange(index, count)",
                    a => new BSWrapperObject_System_Collections_ArrayList(
                        m_InternalObject.GetRange(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort()",
                    a =>
                    {
                        m_InternalObject.Sort();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(comparer)",
                    a =>
                    {
                        m_InternalObject.Sort( WrapperHelper.UnwrapObject < IComparer >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Sort"] = new BSFunctionReference(
                new BSFunction(
                    "function Sort(index, count, comparer)",
                    a =>
                    {
                        m_InternalObject.Sort(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < IComparer >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["TrimToSize"] = new BSFunctionReference(
                new BSFunction(
                    "function TrimToSize()",
                    a =>
                    {
                        m_InternalObject.TrimToSize();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}

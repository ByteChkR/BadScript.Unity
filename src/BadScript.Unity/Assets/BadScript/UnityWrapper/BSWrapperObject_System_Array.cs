using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Array : BSWrapperObject < Array >

    {
        #region Public

        public BSWrapperObject_System_Array( Array obj ) : base( obj )
        {
            m_Properties["LongLength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.LongLength ),
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

            m_Properties["Length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Length ),
                null );

            m_Properties["Rank"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Rank ),
                null );

            m_Properties["GetLongLength"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLongLength(dimension)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLongLength( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetValue(index)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.GetValue( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetValue(index1, index2)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.GetValue(
                            WrapperHelper.UnwrapObject < long >( a[0] ),
                            WrapperHelper.UnwrapObject < long >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetValue(index1, index2, index3)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.GetValue(
                            WrapperHelper.UnwrapObject < long >( a[0] ),
                            WrapperHelper.UnwrapObject < long >( a[1] ),
                            WrapperHelper.UnwrapObject < long >( a[2] ) ) ),
                    3 ) );

            m_Properties["GetLength"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLength(dimension)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLength( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetLowerBound"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLowerBound(dimension)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLowerBound( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUpperBound"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUpperBound(dimension)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUpperBound( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetValue(index)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.GetValue( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetValue(index1, index2)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.GetValue(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetValue(index1, index2, index3)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.GetValue(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

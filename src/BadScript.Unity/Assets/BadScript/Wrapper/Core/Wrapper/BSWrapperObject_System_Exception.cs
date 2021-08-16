using System;
using System.Runtime.Serialization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Exception : BSWrapperObject < Exception >

    {
        #region Public

        public BSWrapperObject_System_Exception( Exception obj ) : base( obj )
        {
            m_Properties["Message"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Message ), null );

            m_Properties["Data"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Collections_IDictionary( m_InternalObject.Data ),
                null );

            m_Properties["InnerException"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Exception( m_InternalObject.InnerException ),
                null );

            m_Properties["TargetSite"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_MethodBase( m_InternalObject.TargetSite ),
                null );

            m_Properties["StackTrace"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.StackTrace ),
                null );

            m_Properties["HelpLink"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.HelpLink ),
                x => m_InternalObject.HelpLink = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Source"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.Source ),
                x => m_InternalObject.Source = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["HResult"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.HResult ),
                null );

            m_Properties["GetBaseException"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBaseException()",
                    a => new BSWrapperObject_System_Exception( m_InternalObject.GetBaseException() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

            m_Properties["GetObjectData"] = new BSFunctionReference(
                new BSFunction(
                    "function GetObjectData(info, context)",
                    a =>
                    {
                        m_InternalObject.GetObjectData(
                            WrapperHelper.UnwrapObject < SerializationInfo >( a[0] ),
                            WrapperHelper.UnwrapObject < StreamingContext >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

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

        }

        #endregion
    }

}

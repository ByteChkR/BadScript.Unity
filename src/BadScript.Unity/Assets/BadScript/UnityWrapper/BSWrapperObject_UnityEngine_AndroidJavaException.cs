using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AndroidJavaException : BSWrapperObject < AndroidJavaException >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AndroidJavaException( AndroidJavaException obj ) : base( obj )
        {
            m_Properties["StackTrace"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.StackTrace ),
                null );

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

            m_Properties["HelpLink"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.HelpLink ),
                x => m_InternalObject.HelpLink = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Source"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.Source ),
                x => m_InternalObject.Source = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["HResult"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.HResult ),
                null );

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

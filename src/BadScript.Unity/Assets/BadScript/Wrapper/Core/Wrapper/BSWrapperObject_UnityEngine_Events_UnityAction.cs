using System;
using System.Runtime.Serialization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Events;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Events_UnityAction : BSWrapperObject < UnityAction >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Events_UnityAction( UnityAction obj ) : base( obj )
        {
            m_Properties["Method"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_MethodInfo( m_InternalObject.Method ),
                null );

            m_Properties["Target"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Target ),
                null );

            m_Properties["Invoke"] = new BSFunctionReference(
                new BSFunction(
                    "function Invoke()",
                    a =>
                    {
                        m_InternalObject.Invoke();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["BeginInvoke"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginInvoke(callback, object)",
                    a => new BSWrapperObject_System_IAsyncResult(
                        m_InternalObject.BeginInvoke(
                            WrapperHelper.UnwrapObject < AsyncCallback >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

            m_Properties["EndInvoke"] = new BSFunctionReference(
                new BSFunction(
                    "function EndInvoke(result)",
                    a =>
                    {
                        m_InternalObject.EndInvoke( WrapperHelper.UnwrapObject < IAsyncResult >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

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

            m_Properties["Clone"] = new BSFunctionReference(
                new BSFunction(
                    "function Clone()",
                    a => new BSWrapperObject_System_Object( m_InternalObject.Clone() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}

using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_ComputeBuffer : BSWrapperObject < ComputeBuffer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ComputeBuffer( ComputeBuffer obj ) : base( obj )
        {
            m_Properties["count"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.count ),
                null );

            m_Properties["stride"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stride ),
                null );

            m_Properties["Dispose"] = new BSFunctionReference(
                new BSFunction(
                    "function Dispose()",
                    a =>
                    {
                        m_InternalObject.Dispose();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Release"] = new BSFunctionReference(
                new BSFunction(
                    "function Release()",
                    a =>
                    {
                        m_InternalObject.Release();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["IsValid"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValid()",
                    a => m_InternalObject.IsValid() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["SetData"] = new BSFunctionReference(
                new BSFunction(
                    "function SetData(data)",
                    a =>
                    {
                        m_InternalObject.SetData( WrapperHelper.UnwrapObject < Array >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetData"] = new BSFunctionReference(
                new BSFunction(
                    "function SetData(data, managedBufferStartIndex, computeBufferStartIndex, count)",
                    a =>
                    {
                        m_InternalObject.SetData(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["GetData"] = new BSFunctionReference(
                new BSFunction(
                    "function GetData(data)",
                    a =>
                    {
                        m_InternalObject.GetData( WrapperHelper.UnwrapObject < Array >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetData"] = new BSFunctionReference(
                new BSFunction(
                    "function GetData(data, managedBufferStartIndex, computeBufferStartIndex, count)",
                    a =>
                    {
                        m_InternalObject.GetData(
                            WrapperHelper.UnwrapObject < Array >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetCounterValue"] = new BSFunctionReference(
                new BSFunction(
                    "function SetCounterValue(counterValue)",
                    a =>
                    {
                        m_InternalObject.SetCounterValue( WrapperHelper.UnwrapObject < uint >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetNativeBufferPtr"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNativeBufferPtr()",
                    a => new BSWrapperObject_System_IntPtr( m_InternalObject.GetNativeBufferPtr() ),
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

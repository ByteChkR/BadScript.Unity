using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using Object = UnityEngine.Object;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_ILogger : BSWrapperObject < ILogger >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ILogger( ILogger obj ) : base( obj )
        {
            m_Properties["logHandler"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ILogHandler( m_InternalObject.logHandler ),
                x => m_InternalObject.logHandler = WrapperHelper.UnwrapObject < ILogHandler >( x ) );

            m_Properties["logEnabled"] = new BSReflectionReference(
                () => m_InternalObject.logEnabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.logEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["Log"] = new BSFunctionReference(
                new BSFunction(
                    "function Log(message)",
                    a =>
                    {
                        m_InternalObject.Log( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Log"] = new BSFunctionReference(
                new BSFunction(
                    "function Log(tag, message)",
                    a =>
                    {
                        m_InternalObject.Log(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Log"] = new BSFunctionReference(
                new BSFunction(
                    "function Log(tag, message, context)",
                    a =>
                    {
                        m_InternalObject.Log(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < Object >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["LogWarning"] = new BSFunctionReference(
                new BSFunction(
                    "function LogWarning(tag, message)",
                    a =>
                    {
                        m_InternalObject.LogWarning(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["LogWarning"] = new BSFunctionReference(
                new BSFunction(
                    "function LogWarning(tag, message, context)",
                    a =>
                    {
                        m_InternalObject.LogWarning(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < Object >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["LogError"] = new BSFunctionReference(
                new BSFunction(
                    "function LogError(tag, message)",
                    a =>
                    {
                        m_InternalObject.LogError(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["LogError"] = new BSFunctionReference(
                new BSFunction(
                    "function LogError(tag, message, context)",
                    a =>
                    {
                        m_InternalObject.LogError(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < Object >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["LogException"] = new BSFunctionReference(
                new BSFunction(
                    "function LogException(exception)",
                    a =>
                    {
                        m_InternalObject.LogException( WrapperHelper.UnwrapObject < Exception >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

        }

        #endregion
    }

}

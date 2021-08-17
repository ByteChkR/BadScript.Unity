using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using Object = UnityEngine.Object;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Debug : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Debug() : base( typeof( Debug ) )
        {
            m_StaticProperties["unityLogger"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ILogger( Debug.unityLogger ),
                null );

            m_StaticProperties["developerConsoleVisible"] = new BSReflectionReference(
                () => Debug.developerConsoleVisible ? BSObject.One : BSObject.Zero,
                x => Debug.developerConsoleVisible = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["isDebugBuild"] = new BSReflectionReference(
                () => Debug.isDebugBuild ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["logger"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ILogger( Debug.unityLogger ),
                null );

            m_StaticProperties["DrawLine"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawLine(start, end, color, duration)",
                    a =>
                    {
                        Debug.DrawLine(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_StaticProperties["DrawLine"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawLine(start, end, color)",
                    a =>
                    {
                        Debug.DrawLine(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["DrawLine"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawLine(start, end)",
                    a =>
                    {
                        Debug.DrawLine(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["DrawLine"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawLine(start, end, color, duration, depthTest)",
                    a =>
                    {
                        Debug.DrawLine(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < bool >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_StaticProperties["DrawRay"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawRay(start, dir, color, duration)",
                    a =>
                    {
                        Debug.DrawRay(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_StaticProperties["DrawRay"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawRay(start, dir, color)",
                    a =>
                    {
                        Debug.DrawRay(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["DrawRay"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawRay(start, dir)",
                    a =>
                    {
                        Debug.DrawRay(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["DrawRay"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawRay(start, dir, color, duration, depthTest)",
                    a =>
                    {
                        Debug.DrawRay(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < bool >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_StaticProperties["Break"] = new BSFunctionReference(
                new BSFunction(
                    "function Break()",
                    a =>
                    {
                        Debug.Break();

                        return new BSObject( null );
                    },
                    0 ) );

            m_StaticProperties["DebugBreak"] = new BSFunctionReference(
                new BSFunction(
                    "function DebugBreak()",
                    a =>
                    {
                        Debug.DebugBreak();

                        return new BSObject( null );
                    },
                    0 ) );

            m_StaticProperties["Log"] = new BSFunctionReference(
                new BSFunction(
                    "function Log(message)",
                    a =>
                    {
                        Debug.Log( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["Log"] = new BSFunctionReference(
                new BSFunction(
                    "function Log(message, context)",
                    a =>
                    {
                        Debug.Log(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["LogError"] = new BSFunctionReference(
                new BSFunction(
                    "function LogError(message)",
                    a =>
                    {
                        Debug.LogError( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["LogError"] = new BSFunctionReference(
                new BSFunction(
                    "function LogError(message, context)",
                    a =>
                    {
                        Debug.LogError(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["ClearDeveloperConsole"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearDeveloperConsole()",
                    a =>
                    {
                        Debug.ClearDeveloperConsole();

                        return new BSObject( null );
                    },
                    0 ) );

            m_StaticProperties["LogException"] = new BSFunctionReference(
                new BSFunction(
                    "function LogException(exception)",
                    a =>
                    {
                        Debug.LogException( WrapperHelper.UnwrapObject < Exception >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["LogException"] = new BSFunctionReference(
                new BSFunction(
                    "function LogException(exception, context)",
                    a =>
                    {
                        Debug.LogException(
                            WrapperHelper.UnwrapObject < Exception >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["LogWarning"] = new BSFunctionReference(
                new BSFunction(
                    "function LogWarning(message)",
                    a =>
                    {
                        Debug.LogWarning( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["LogWarning"] = new BSFunctionReference(
                new BSFunction(
                    "function LogWarning(message, context)",
                    a =>
                    {
                        Debug.LogWarning(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["Assert"] = new BSFunctionReference(
                new BSFunction(
                    "function Assert(condition)",
                    a =>
                    {
                        Debug.Assert( WrapperHelper.UnwrapObject < bool >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["Assert"] = new BSFunctionReference(
                new BSFunction(
                    "function Assert(condition, context)",
                    a =>
                    {
                        Debug.Assert(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["Assert"] = new BSFunctionReference(
                new BSFunction(
                    "function Assert(condition, message)",
                    a =>
                    {
                        Debug.Assert(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["Assert"] = new BSFunctionReference(
                new BSFunction(
                    "function Assert(condition, message)",
                    a =>
                    {
                        Debug.Assert(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["Assert"] = new BSFunctionReference(
                new BSFunction(
                    "function Assert(condition, message, context)",
                    a =>
                    {
                        Debug.Assert(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ),
                            WrapperHelper.UnwrapObject < Object >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["Assert"] = new BSFunctionReference(
                new BSFunction(
                    "function Assert(condition, message, context)",
                    a =>
                    {
                        Debug.Assert(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < Object >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["LogAssertion"] = new BSFunctionReference(
                new BSFunction(
                    "function LogAssertion(message)",
                    a =>
                    {
                        Debug.LogAssertion( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["LogAssertion"] = new BSFunctionReference(
                new BSFunction(
                    "function LogAssertion(message, context)",
                    a =>
                    {
                        Debug.LogAssertion(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

        }

        #endregion
    }

}

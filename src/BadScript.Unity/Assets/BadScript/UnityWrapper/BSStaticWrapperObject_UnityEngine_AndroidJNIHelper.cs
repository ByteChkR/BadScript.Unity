using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AndroidJNIHelper : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AndroidJNIHelper() : base( typeof( AndroidJNIHelper ) )
        {
            m_StaticProperties["debug"] = new BSReflectionReference(
                () => AndroidJNIHelper.debug ? BSObject.One : BSObject.Zero,
                x => AndroidJNIHelper.debug = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["GetConstructorID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetConstructorID(javaClass)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.GetConstructorID( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetConstructorID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetConstructorID(javaClass, signature)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.GetConstructorID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetMethodID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMethodID(javaClass, methodName)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.GetMethodID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetMethodID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMethodID(javaClass, methodName, signature)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.GetMethodID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetMethodID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMethodID(javaClass, methodName, signature, isStatic)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.GetMethodID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ),
                            WrapperHelper.UnwrapObject < bool >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["GetFieldID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFieldID(javaClass, fieldName)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.GetFieldID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetFieldID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFieldID(javaClass, fieldName, signature)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.GetFieldID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetFieldID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFieldID(javaClass, fieldName, signature, isStatic)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.GetFieldID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ),
                            WrapperHelper.UnwrapObject < bool >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["CreateJavaRunnable"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateJavaRunnable(jrunnable)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.CreateJavaRunnable(
                            WrapperHelper.UnwrapObject < AndroidJavaRunnable >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CreateJavaProxy"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateJavaProxy(proxy)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.CreateJavaProxy( WrapperHelper.UnwrapObject < AndroidJavaProxy >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ConvertToJNIArray"] = new BSFunctionReference(
                new BSFunction(
                    "function ConvertToJNIArray(array)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNIHelper.ConvertToJNIArray( WrapperHelper.UnwrapObject < Array >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetSignature"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSignature(obj)",
                    a => new BSObject( AndroidJNIHelper.GetSignature( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            //m_StaticProperties["GetFieldID"] = new BSFunctionReference(new BSFunction("function GetFieldID(jclass, fieldName, isStatic)", a => new BSWrapperObject_System_IntPtr(UnityEngine.AndroidJNIHelper.GetFieldID(WrapperHelper.UnwrapObject<System.IntPtr>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<System.Boolean>(a[2]))), 3));

        }

        #endregion
    }

}

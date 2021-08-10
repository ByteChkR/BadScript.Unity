using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AndroidJNI : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AndroidJNI() : base( typeof( AndroidJNI ) )
        {
            m_StaticProperties["FindClass"] = new BSFunctionReference(
                new BSFunction(
                    "function FindClass(name)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.FindClass( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromReflectedMethod"] = new BSFunctionReference(
                new BSFunction(
                    "function FromReflectedMethod(refMethod)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.FromReflectedMethod( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromReflectedField"] = new BSFunctionReference(
                new BSFunction(
                    "function FromReflectedField(refField)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.FromReflectedField( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ToReflectedMethod"] = new BSFunctionReference(
                new BSFunction(
                    "function ToReflectedMethod(clazz, methodID, isStatic)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.ToReflectedMethod(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["ToReflectedField"] = new BSFunctionReference(
                new BSFunction(
                    "function ToReflectedField(clazz, fieldID, isStatic)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.ToReflectedField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetSuperclass"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSuperclass(clazz)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetSuperclass( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsAssignableFrom"] = new BSFunctionReference(
                new BSFunction(
                    "function IsAssignableFrom(clazz1, clazz2)",
                    a => AndroidJNI.IsAssignableFrom(
                        WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                        WrapperHelper.UnwrapObject < IntPtr >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Throw"] = new BSFunctionReference(
                new BSFunction(
                    "function Throw(obj)",
                    a => new BSObject( ( decimal ) AndroidJNI.Throw( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ThrowNew"] = new BSFunctionReference(
                new BSFunction(
                    "function ThrowNew(clazz, message)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.ThrowNew(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["PushLocalFrame"] = new BSFunctionReference(
                new BSFunction(
                    "function PushLocalFrame(capacity)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.PushLocalFrame( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["PopLocalFrame"] = new BSFunctionReference(
                new BSFunction(
                    "function PopLocalFrame(ptr)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.PopLocalFrame( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewGlobalRef"] = new BSFunctionReference(
                new BSFunction(
                    "function NewGlobalRef(obj)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewGlobalRef( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewWeakGlobalRef"] = new BSFunctionReference(
                new BSFunction(
                    "function NewWeakGlobalRef(obj)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewWeakGlobalRef( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewLocalRef"] = new BSFunctionReference(
                new BSFunction(
                    "function NewLocalRef(obj)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewLocalRef( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsSameObject"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSameObject(obj1, obj2)",
                    a => AndroidJNI.IsSameObject(
                        WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                        WrapperHelper.UnwrapObject < IntPtr >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["EnsureLocalCapacity"] = new BSFunctionReference(
                new BSFunction(
                    "function EnsureLocalCapacity(capacity)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.EnsureLocalCapacity( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["AllocObject"] = new BSFunctionReference(
                new BSFunction(
                    "function AllocObject(clazz)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.AllocObject( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetObjectClass"] = new BSFunctionReference(
                new BSFunction(
                    "function GetObjectClass(obj)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetObjectClass( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsInstanceOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IsInstanceOf(obj, clazz)",
                    a => AndroidJNI.IsInstanceOf(
                        WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                        WrapperHelper.UnwrapObject < IntPtr >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetMethodID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMethodID(clazz, name, sig)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetMethodID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetFieldID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFieldID(clazz, name, sig)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetFieldID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetStaticMethodID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticMethodID(clazz, name, sig)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetStaticMethodID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetStaticFieldID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticFieldID(clazz, name, sig)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetStaticFieldID(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["NewString"] = new BSFunctionReference(
                new BSFunction(
                    "function NewString(chars)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewStringUTF"] = new BSFunctionReference(
                new BSFunction(
                    "function NewStringUTF(bytes)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewStringUTF( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetStringChars"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStringChars(str)",
                    a => new BSObject( AndroidJNI.GetStringChars( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetStringLength"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStringLength(str)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStringLength( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetStringUTFLength"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStringUTFLength(str)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStringUTFLength( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetStringUTFChars"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStringUTFChars(str)",
                    a => new BSObject( AndroidJNI.GetStringUTFChars( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetStringField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStringField(obj, fieldID)",
                    a => new BSObject(
                        AndroidJNI.GetStringField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetObjectField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetObjectField(obj, fieldID)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetObjectField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetBooleanField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBooleanField(obj, fieldID)",
                    a => AndroidJNI.GetBooleanField(
                        WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                        WrapperHelper.UnwrapObject < IntPtr >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetByteField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetByteField(obj, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetByteField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetSByteField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSByteField(obj, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetSByteField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetCharField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCharField(obj, fieldID)",
                    a => new BSWrapperObject_System_Char(
                        AndroidJNI.GetCharField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetShortField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetShortField(obj, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetShortField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetIntField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIntField(obj, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetIntField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetLongField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLongField(obj, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetLongField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetFloatField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloatField(obj, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetFloatField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetDoubleField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDoubleField(obj, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetDoubleField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticStringField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticStringField(clazz, fieldID)",
                    a => new BSObject(
                        AndroidJNI.GetStaticStringField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticObjectField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticObjectField(clazz, fieldID)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetStaticObjectField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticBooleanField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticBooleanField(clazz, fieldID)",
                    a => AndroidJNI.GetStaticBooleanField(
                        WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                        WrapperHelper.UnwrapObject < IntPtr >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetStaticByteField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticByteField(clazz, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStaticByteField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticSByteField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticSByteField(clazz, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStaticSByteField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticCharField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticCharField(clazz, fieldID)",
                    a => new BSWrapperObject_System_Char(
                        AndroidJNI.GetStaticCharField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticShortField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticShortField(clazz, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStaticShortField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticIntField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticIntField(clazz, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStaticIntField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticLongField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticLongField(clazz, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStaticLongField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticFloatField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticFloatField(clazz, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStaticFloatField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetStaticDoubleField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStaticDoubleField(clazz, fieldID)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetStaticDoubleField(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetArrayLength"] = new BSFunctionReference(
                new BSFunction(
                    "function GetArrayLength(array)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetArrayLength( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewBooleanArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewBooleanArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewBooleanArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewByteArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewByteArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewByteArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewSByteArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewSByteArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewSByteArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewCharArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewCharArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewCharArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewShortArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewShortArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewShortArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewIntArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewIntArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewIntArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewLongArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewLongArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewLongArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewFloatArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewFloatArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewFloatArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewDoubleArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewDoubleArray(size)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewDoubleArray( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NewObjectArray"] = new BSFunctionReference(
                new BSFunction(
                    "function NewObjectArray(size, clazz, obj)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.NewObjectArray(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetBooleanArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBooleanArrayElement(array, index)",
                    a => AndroidJNI.GetBooleanArrayElement(
                        WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetByteArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetByteArrayElement(array, index)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetByteArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetSByteArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSByteArrayElement(array, index)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetSByteArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetCharArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCharArrayElement(array, index)",
                    a => new BSWrapperObject_System_Char(
                        AndroidJNI.GetCharArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetShortArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetShortArrayElement(array, index)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetShortArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetIntArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIntArrayElement(array, index)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetIntArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetLongArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLongArrayElement(array, index)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetLongArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetFloatArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloatArrayElement(array, index)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetFloatArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetDoubleArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDoubleArrayElement(array, index)",
                    a => new BSObject(
                        ( decimal ) AndroidJNI.GetDoubleArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetObjectArrayElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetObjectArrayElement(array, index)",
                    a => new BSWrapperObject_System_IntPtr(
                        AndroidJNI.GetObjectArrayElement(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

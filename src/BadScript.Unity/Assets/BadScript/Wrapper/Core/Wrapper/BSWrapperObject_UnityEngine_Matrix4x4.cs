using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Matrix4x4 : BSWrapperObject < Matrix4x4 >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Matrix4x4( Matrix4x4 obj ) : base( obj )
        {
            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.rotation ),
                null );

            m_Properties["lossyScale"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.lossyScale ),
                null );

            m_Properties["isIdentity"] = new BSReflectionReference(
                () => m_InternalObject.isIdentity ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["determinant"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.determinant ),
                null );

            m_Properties["decomposeProjection"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_FrustumPlanes( m_InternalObject.decomposeProjection ),
                null );

            m_Properties["inverse"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.inverse ),
                null );

            m_Properties["transpose"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.transpose ),
                null );

            m_Properties["get_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function get_Item(row, column)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] ),
                                                     WrapperHelper.UnwrapObject < int >( a[1] )] ),
                    2 ) );

            m_Properties["set_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function set_Item(row, column, value)",
                    a =>
                    {
                        m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] ),
                                         WrapperHelper.UnwrapObject < int >( a[1] )] =
                            WrapperHelper.UnwrapObject < float >( a[2] );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["get_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function get_Item(index)",
                    a => new BSObject( ( decimal ) m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] ),
                    1 ) );

            m_Properties["set_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function set_Item(index, value)",
                    a =>
                    {
                        m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] =
                            WrapperHelper.UnwrapObject < float >( a[1] );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["m00"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m00 ),
                x => m_InternalObject.m00 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m10"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m10 ),
                x => m_InternalObject.m10 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m20"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m20 ),
                x => m_InternalObject.m20 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m30"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m30 ),
                x => m_InternalObject.m30 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m01"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m01 ),
                x => m_InternalObject.m01 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m11"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m11 ),
                x => m_InternalObject.m11 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m21"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m21 ),
                x => m_InternalObject.m21 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m31"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m31 ),
                x => m_InternalObject.m31 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m02"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m02 ),
                x => m_InternalObject.m02 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m12"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m12 ),
                x => m_InternalObject.m12 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m22"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m22 ),
                x => m_InternalObject.m22 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m32"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m32 ),
                x => m_InternalObject.m32 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m03"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m03 ),
                x => m_InternalObject.m03 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m13"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m13 ),
                x => m_InternalObject.m13 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m23"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m23 ),
                x => m_InternalObject.m23 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["m33"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.m33 ),
                x => m_InternalObject.m33 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["ValidTRS"] = new BSFunctionReference(
                new BSFunction(
                    "function ValidTRS()",
                    a => m_InternalObject.ValidTRS() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["SetTRS"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTRS(pos, q, s)",
                    a =>
                    {
                        m_InternalObject.SetTRS(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Matrix4x4 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetColumn"] = new BSFunctionReference(
                new BSFunction(
                    "function GetColumn(index)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetColumn( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetRow"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRow(index)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetRow( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["SetColumn"] = new BSFunctionReference(
                new BSFunction(
                    "function SetColumn(index, column)",
                    a =>
                    {
                        m_InternalObject.SetColumn(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetRow"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRow(index, row)",
                    a =>
                    {
                        m_InternalObject.SetRow(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["MultiplyPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function MultiplyPoint(point)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.MultiplyPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["MultiplyPoint3x4"] = new BSFunctionReference(
                new BSFunction(
                    "function MultiplyPoint3x4(point)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.MultiplyPoint3x4( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["MultiplyVector"] = new BSFunctionReference(
                new BSFunction(
                    "function MultiplyVector(vector)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.MultiplyVector( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["TransformPlane"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformPlane(plane)",
                    a => new BSWrapperObject_UnityEngine_Plane(
                        m_InternalObject.TransformPlane( WrapperHelper.UnwrapObject < Plane >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format)",
                    a => new BSObject( m_InternalObject.ToString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format, formatProvider)",
                    a => new BSObject(
                        m_InternalObject.ToString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

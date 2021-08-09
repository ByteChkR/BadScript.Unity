using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace BadScript.Wrapper.Internal
{

    public class BSWrapperObject_GameObject : BSWrapperObject < GameObject >

    {
        #region Public

        public BSWrapperObject_GameObject( GameObject obj ) : base( obj )
        {
            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_Transform( m_InternalObject.transform ),
                null );

            m_Properties["layer"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layer ),
                x => m_InternalObject.layer = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["active"] = new BSReflectionReference(
                () => m_InternalObject.active ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.active = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["activeSelf"] = new BSReflectionReference(
                () => m_InternalObject.activeSelf ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["activeInHierarchy"] = new BSReflectionReference(
                () => m_InternalObject.activeInHierarchy ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isStatic"] = new BSReflectionReference(
                () => m_InternalObject.isStatic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isStatic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["scene"] = new BSReflectionReference(
                () => new BSWrapperObject_Scene( m_InternalObject.scene ),
                null );

            m_Properties["sceneCullingMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sceneCullingMask ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponentInChildren"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponentInChildren(type, includeInactive)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponentInChildren(
                            WrapperHelper.UnwrapObject < Type >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetComponentInParent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponentInParent(type, includeInactive)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponentInParent(
                            WrapperHelper.UnwrapObject < Type >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_GameObject : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_GameObject() : base( typeof( GameObject ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Transform : BSWrapperObject < Transform >

    {
        #region Public

        public BSWrapperObject_Transform( Transform obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["localPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.localPosition ),
                x => m_InternalObject.localPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["eulerAngles"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.eulerAngles ),
                x => m_InternalObject.eulerAngles = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["localEulerAngles"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.localEulerAngles ),
                x => m_InternalObject.localEulerAngles = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.right ),
                x => m_InternalObject.right = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["up"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.up ),
                x => m_InternalObject.up = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["forward"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.forward ),
                x => m_InternalObject.forward = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["localRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.localRotation ),
                x => m_InternalObject.localRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["localScale"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.localScale ),
                x => m_InternalObject.localScale = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["worldToLocalMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_Matrix4x4( m_InternalObject.worldToLocalMatrix ),
                null );

            m_Properties["localToWorldMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_Matrix4x4( m_InternalObject.localToWorldMatrix ),
                null );

            m_Properties["childCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.childCount ),
                null );

            m_Properties["lossyScale"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.lossyScale ),
                null );

            m_Properties["hasChanged"] = new BSReflectionReference(
                () => m_InternalObject.hasChanged ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.hasChanged = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["hierarchyCapacity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.hierarchyCapacity ),
                x => m_InternalObject.hierarchyCapacity = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["hierarchyCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.hierarchyCount ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["TransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformDirection(direction)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformDirection( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["TransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformDirection(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformDirection(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformDirection(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformDirection(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformDirection(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformDirection(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformDirection(direction)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformDirection( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["InverseTransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformDirection(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformDirection(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformDirection(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformDirection(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformDirection(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformDirection(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformVector(vector)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformVector( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["TransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformVector(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformVector(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformVector(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformVector(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformVector(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformVector(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformVector(vector)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformVector( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["InverseTransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformVector(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformVector(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformVector(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformVector(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformVector(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformVector(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformPoint(position)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["TransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformPoint(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformPoint(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformPoint(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformPoint(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformPoint(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.TransformPoint(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformPoint(position)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["InverseTransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformPoint(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformPoint(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformPoint(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformPoint(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformPoint(x, y, z)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.InverseTransformPoint(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponentInChildren"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponentInChildren(t, includeInactive)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponentInChildren(
                            WrapperHelper.UnwrapObject < Type >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_Transform : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Transform() : base( typeof( Transform ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Vector3 : BSWrapperObject < Vector3 >

    {
        #region Public

        public BSWrapperObject_Vector3( Vector3 obj ) : base( obj )
        {
            m_Properties["magnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.magnitude ),
                null );

            m_Properties["sqrMagnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sqrMagnitude ),
                null );

            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["z"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.z ),
                x => m_InternalObject.z = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

    public class BSStaticWrapperObject_Vector3 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Vector3() : base( typeof( Vector3 ) )
        {
            m_StaticProperties["kEpsilon"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vector3.kEpsilon ),
                null );

            m_StaticProperties["kEpsilonNormalSqrt"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vector3.kEpsilonNormalSqrt ),
                null );

        }

        #endregion
    }

    public class BSWrapperObject_Object : BSWrapperObject < object >

    {
        #region Public

        public BSWrapperObject_Object( object obj ) : base( obj )
        {

        }

        #endregion
    }

    public class BSStaticWrapperObject_Object : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Object() : base( typeof( object ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_IFormatProvider : BSWrapperObject < IFormatProvider >

    {
        #region Public

        public BSWrapperObject_IFormatProvider( IFormatProvider obj ) : base( obj )
        {

        }

        #endregion
    }

    public class BSStaticWrapperObject_IFormatProvider : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_IFormatProvider() : base( typeof( IFormatProvider ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Quaternion : BSWrapperObject < Quaternion >

    {
        #region Public

        public BSWrapperObject_Quaternion( Quaternion obj ) : base( obj )
        {
            m_Properties["eulerAngles"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.eulerAngles ),
                x => m_InternalObject.eulerAngles = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["z"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.z ),
                x => m_InternalObject.z = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["w"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.w ),
                x => m_InternalObject.w = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

    public class BSStaticWrapperObject_Quaternion : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Quaternion() : base( typeof( Quaternion ) )
        {
            m_StaticProperties["kEpsilon"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Quaternion.kEpsilon ),
                null );

        }

        #endregion
    }

    public class BSWrapperObject_Matrix4x4 : BSWrapperObject < Matrix4x4 >

    {
        #region Public

        public BSWrapperObject_Matrix4x4( Matrix4x4 obj ) : base( obj )
        {
            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.rotation ),
                null );

            m_Properties["lossyScale"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.lossyScale ),
                null );

            m_Properties["isIdentity"] = new BSReflectionReference(
                () => m_InternalObject.isIdentity ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["determinant"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.determinant ),
                null );

            m_Properties["decomposeProjection"] = new BSReflectionReference(
                () => new BSWrapperObject_FrustumPlanes( m_InternalObject.decomposeProjection ),
                null );

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

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetColumn"] = new BSFunctionReference(
                new BSFunction(
                    "function GetColumn(index)",
                    a => new BSWrapperObject_Vector4(
                        m_InternalObject.GetColumn( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetRow"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRow(index)",
                    a => new BSWrapperObject_Vector4(
                        m_InternalObject.GetRow( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["MultiplyPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function MultiplyPoint(point)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.MultiplyPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["MultiplyPoint3x4"] = new BSFunctionReference(
                new BSFunction(
                    "function MultiplyPoint3x4(point)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.MultiplyPoint3x4( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["MultiplyVector"] = new BSFunctionReference(
                new BSFunction(
                    "function MultiplyVector(vector)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.MultiplyVector( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["TransformPlane"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformPlane(plane)",
                    a => new BSWrapperObject_Plane(
                        m_InternalObject.TransformPlane( WrapperHelper.UnwrapObject < Plane >( a[0] ) ) ),
                    1 ) );

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

    public class BSStaticWrapperObject_Matrix4x4 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Matrix4x4() : base( typeof( Matrix4x4 ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_FrustumPlanes : BSWrapperObject < FrustumPlanes >

    {
        #region Public

        public BSWrapperObject_FrustumPlanes( FrustumPlanes obj ) : base( obj )
        {
            m_Properties["left"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.left ),
                x => m_InternalObject.left = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.right ),
                x => m_InternalObject.right = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bottom"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bottom ),
                x => m_InternalObject.bottom = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["top"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.top ),
                x => m_InternalObject.top = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["zNear"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.zNear ),
                x => m_InternalObject.zNear = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["zFar"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.zFar ),
                x => m_InternalObject.zFar = WrapperHelper.UnwrapObject < float >( x ) );

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

    public class BSStaticWrapperObject_FrustumPlanes : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_FrustumPlanes() : base( typeof( FrustumPlanes ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Vector4 : BSWrapperObject < Vector4 >

    {
        #region Public

        public BSWrapperObject_Vector4( Vector4 obj ) : base( obj )
        {
            m_Properties["magnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.magnitude ),
                null );

            m_Properties["sqrMagnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sqrMagnitude ),
                null );

            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["z"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.z ),
                x => m_InternalObject.z = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["w"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.w ),
                x => m_InternalObject.w = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

    public class BSStaticWrapperObject_Vector4 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Vector4() : base( typeof( Vector4 ) )
        {
            m_StaticProperties["kEpsilon"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vector4.kEpsilon ),
                null );

        }

        #endregion
    }

    public class BSWrapperObject_Plane : BSWrapperObject < Plane >

    {
        #region Public

        public BSWrapperObject_Plane( Plane obj ) : base( obj )
        {
            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.normal ),
                x => m_InternalObject.normal = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["distance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distance ),
                x => m_InternalObject.distance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["ClosestPointOnPlane"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPointOnPlane(point)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.ClosestPointOnPlane( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetDistanceToPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDistanceToPoint(point)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetDistanceToPoint(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSide"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSide(point)",
                    a => m_InternalObject.GetSide( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["SameSide"] = new BSFunctionReference(
                new BSFunction(
                    "function SameSide(inPt0, inPt1)",
                    a => m_InternalObject.SameSide(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["SameSide"] = new BSFunctionReference(
                new BSFunction(
                    "function SameSide(inPt0, inPt1)",
                    a => m_InternalObject.SameSide(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

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

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format, formatProvider)",
                    a => new BSObject(
                        m_InternalObject.ToString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

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

    public class BSStaticWrapperObject_Plane : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Plane() : base( typeof( Plane ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_IEnumerator : BSWrapperObject < IEnumerator >

    {
        #region Public

        public BSWrapperObject_IEnumerator( IEnumerator obj ) : base( obj )
        {
            m_Properties["Current"] = new BSReflectionReference(
                () => new BSWrapperObject_Object( m_InternalObject.Current ),
                null );

        }

        #endregion
    }

    public class BSStaticWrapperObject_IEnumerator : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_IEnumerator() : base( typeof( IEnumerator ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Component : BSWrapperObject < Component >

    {
        #region Public

        public BSWrapperObject_Component( Component obj ) : base( obj )
        {
            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_Component : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Component() : base( typeof( Component ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Scene : BSWrapperObject < Scene >

    {
        #region Public

        public BSWrapperObject_Scene( Scene obj ) : base( obj )
        {
            m_Properties["handle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.handle ),
                null );

            m_Properties["path"] = new BSReflectionReference( () => new BSObject( m_InternalObject.path ), null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["isLoaded"] = new BSReflectionReference(
                () => m_InternalObject.isLoaded ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["buildIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.buildIndex ),
                null );

            m_Properties["isDirty"] = new BSReflectionReference(
                () => m_InternalObject.isDirty ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["rootCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rootCount ),
                null );

            m_Properties["isSubScene"] = new BSReflectionReference(
                () => m_InternalObject.isSubScene ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isSubScene = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_Scene : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Scene() : base( typeof( Scene ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_MonoBehaviour : BSWrapperObject < MonoBehaviour >

    {
        #region Public

        public BSWrapperObject_MonoBehaviour( MonoBehaviour obj ) : base( obj )
        {
            m_Properties["useGUILayout"] = new BSReflectionReference(
                () => m_InternalObject.useGUILayout ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useGUILayout = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["runInEditMode"] = new BSReflectionReference(
                () => m_InternalObject.runInEditMode ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.runInEditMode = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["IsInvoking"] = new BSFunctionReference(
                new BSFunction(
                    "function IsInvoking(methodName)",
                    a => m_InternalObject.IsInvoking( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(methodName)",
                    a => new BSWrapperObject_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(methodName, value)",
                    a => new BSWrapperObject_Coroutine(
                        m_InternalObject.StartCoroutine(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(methodName, value)",
                    a => new BSWrapperObject_Coroutine(
                        m_InternalObject.StartCoroutine(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(routine)",
                    a => new BSWrapperObject_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < IEnumerator >( a[0] ) ) ),
                    1 ) );

            m_Properties["StartCoroutine_Auto"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine_Auto(routine)",
                    a => new BSWrapperObject_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < IEnumerator >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponentInChildren"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponentInChildren(t, includeInactive)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponentInChildren(
                            WrapperHelper.UnwrapObject < Type >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_MonoBehaviour : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_MonoBehaviour() : base( typeof( MonoBehaviour ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Coroutine : BSWrapperObject < Coroutine >

    {
        #region Public

        public BSWrapperObject_Coroutine( Coroutine obj ) : base( obj )
        {
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

    public class BSStaticWrapperObject_Coroutine : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Coroutine() : base( typeof( Coroutine ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Physics : BSWrapperObject < Physics >

    {
        #region Public

        public BSWrapperObject_Physics( Physics obj ) : base( obj )
        {
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

    public class BSStaticWrapperObject_Physics : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Physics() : base( typeof( Physics ) )
        {
            m_StaticProperties["gravity"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( Physics.gravity ),
                x => Physics.gravity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_StaticProperties["defaultContactOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultContactOffset ),
                x => Physics.defaultContactOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["sleepThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.sleepThreshold ),
                x => Physics.sleepThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["queriesHitTriggers"] = new BSReflectionReference(
                () => Physics.queriesHitTriggers ? BSObject.One : BSObject.Zero,
                x => Physics.queriesHitTriggers = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["queriesHitBackfaces"] = new BSReflectionReference(
                () => Physics.queriesHitBackfaces ? BSObject.One : BSObject.Zero,
                x => Physics.queriesHitBackfaces = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["bounceThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.bounceThreshold ),
                x => Physics.bounceThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultMaxDepenetrationVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultMaxDepenetrationVelocity ),
                x => Physics.defaultMaxDepenetrationVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultSolverIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultSolverIterations ),
                x => Physics.defaultSolverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["defaultSolverVelocityIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultSolverVelocityIterations ),
                x => Physics.defaultSolverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["bounceTreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.bounceTreshold ),
                x => Physics.bounceTreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["sleepVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.sleepVelocity ),
                x => Physics.sleepVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["sleepAngularVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.sleepAngularVelocity ),
                x => Physics.sleepAngularVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["solverIterationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultSolverIterations ),
                x => Physics.defaultSolverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["solverVelocityIterationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultSolverVelocityIterations ),
                x => Physics.defaultSolverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["penetrationPenaltyForce"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.penetrationPenaltyForce ),
                x => Physics.penetrationPenaltyForce = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultMaxAngularSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultMaxAngularSpeed ),
                x => Physics.defaultMaxAngularSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultPhysicsScene"] = new BSReflectionReference(
                () => new BSWrapperObject_PhysicsScene( Physics.defaultPhysicsScene ),
                null );

            m_StaticProperties["autoSimulation"] = new BSReflectionReference(
                () => Physics.autoSimulation ? BSObject.One : BSObject.Zero,
                x => Physics.autoSimulation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autoSyncTransforms"] = new BSReflectionReference(
                () => Physics.autoSyncTransforms ? BSObject.One : BSObject.Zero,
                x => Physics.autoSyncTransforms = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["reuseCollisionCallbacks"] = new BSReflectionReference(
                () => Physics.reuseCollisionCallbacks ? BSObject.One : BSObject.Zero,
                x => Physics.reuseCollisionCallbacks = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["interCollisionDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.interCollisionDistance ),
                x => Physics.interCollisionDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["interCollisionStiffness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.interCollisionStiffness ),
                x => Physics.interCollisionStiffness = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["interCollisionSettingsToggle"] = new BSReflectionReference(
                () => Physics.interCollisionSettingsToggle ? BSObject.One : BSObject.Zero,
                x => Physics.interCollisionSettingsToggle = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["clothGravity"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( Physics.clothGravity ),
                x => Physics.clothGravity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_StaticProperties["IgnoreRaycastLayer"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.IgnoreRaycastLayer ),
                null );

            m_StaticProperties["DefaultRaycastLayers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.DefaultRaycastLayers ),
                null );

            m_StaticProperties["AllLayers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.AllLayers ),
                null );

            m_StaticProperties["GetIgnoreLayerCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIgnoreLayerCollision(layer1, layer2)",
                    a => Physics.GetIgnoreLayerCollision(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetIgnoreLayerCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIgnoreLayerCollision(layer1, layer2)",
                    a => Physics.GetIgnoreLayerCollision(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetIgnoreCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIgnoreCollision(collider1, collider2)",
                    a => Physics.GetIgnoreCollision(
                        WrapperHelper.UnwrapObject < Collider >( a[0] ),
                        WrapperHelper.UnwrapObject < Collider >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetIgnoreCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIgnoreCollision(collider1, collider2)",
                    a => Physics.GetIgnoreCollision(
                        WrapperHelper.UnwrapObject < Collider >( a[0] ),
                        WrapperHelper.UnwrapObject < Collider >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray)",
                    a => Physics.Raycast( WrapperHelper.UnwrapObject < Ray >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask, queryTriggerInteraction)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask, queryTriggerInteraction)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask, queryTriggerInteraction)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    7 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(ray, results)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["RaycastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function RaycastNonAlloc(origin, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.RaycastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(point, collider, position, rotation)",
                    a => new BSWrapperObject_Vector3(
                        Physics.ClosestPoint(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(point, collider, position, rotation)",
                    a => new BSWrapperObject_Vector3(
                        Physics.ClosestPoint(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(point, collider, position, rotation)",
                    a => new BSWrapperObject_Vector3(
                        Physics.ClosestPoint(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(point, collider, position, rotation)",
                    a => new BSWrapperObject_Vector3(
                        Physics.ClosestPoint(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapSphereNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphereNonAlloc(position, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapSphereNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapSphereNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphereNonAlloc(position, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapSphereNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapSphereNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphereNonAlloc(position, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapSphereNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapSphereNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphereNonAlloc(position, radius, results, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapSphereNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapSphereNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphereNonAlloc(position, radius, results, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapSphereNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapSphereNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphereNonAlloc(position, radius, results, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapSphereNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapSphereNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphereNonAlloc(position, radius, results)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapSphereNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["OverlapSphereNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphereNonAlloc(position, radius, results)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapSphereNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius, layerMask, queryTriggerInteraction)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius, layerMask, queryTriggerInteraction)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius, layerMask, queryTriggerInteraction)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius, layerMask)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius, layerMask)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius, layerMask)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["CapsuleCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCastNonAlloc(point1, point2, radius, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.CapsuleCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(origin, radius, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["SphereCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCastNonAlloc(ray, radius, results)",
                    a => new BSObject(
                        ( decimal ) Physics.SphereCastNonAlloc(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask, queryTriggerInteraction)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask, queryTriggerInteraction)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask, queryTriggerInteraction)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask, queryTriggerInteraction)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layermask, queryTriggerInteraction)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layermask, queryTriggerInteraction)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layermask, queryTriggerInteraction)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layermask, queryTriggerInteraction)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layerMask)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layerMask)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layerMask)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layerMask)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results, orientation)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["OverlapBoxNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBoxNonAlloc(center, halfExtents, results)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapBoxNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["BoxCastNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCastNonAlloc(center, halfExtents, direction, results)",
                    a => new BSObject(
                        ( decimal ) Physics.BoxCastNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapCapsuleNonAlloc"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsuleNonAlloc(point0, point1, radius, results)",
                    a => new BSObject(
                        ( decimal ) Physics.OverlapCapsuleNonAlloc(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ) ) ),
                    4 ) );

        }

        #endregion
    }

    public class BSWrapperObject_PhysicsScene : BSWrapperObject < PhysicsScene >

    {
        #region Public

        public BSWrapperObject_PhysicsScene( PhysicsScene obj ) : base( obj )
        {
            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => m_InternalObject.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => m_InternalObject.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => m_InternalObject.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)",
                    a => m_InternalObject.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ),
                        WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, raycastHits, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Raycast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, raycastHits, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Raycast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, raycastHits, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Raycast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, raycastHits, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Raycast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CapsuleCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CapsuleCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CapsuleCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CapsuleCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CapsuleCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CapsuleCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["OverlapCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsule(point0, point1, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapCapsule(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["OverlapCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsule(point0, point1, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapCapsule(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["OverlapCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsule(point0, point1, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapCapsule(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["OverlapCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCapsule(point0, point1, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapCapsule(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.SphereCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_Properties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.SphereCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_Properties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.SphereCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_Properties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.SphereCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_Properties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.SphereCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[6] ) ) ),
                    7 ) );

            m_Properties["OverlapSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphere(position, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapSphere(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_Properties["OverlapSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphere(position, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapSphere(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_Properties["OverlapSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapSphere(position, radius, results, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapSphere(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[4] ) ) ),
                    5 ) );

            m_Properties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(center, halfExtents, results, orientation, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(center, halfExtents, results, orientation, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(center, halfExtents, results, orientation, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(center, halfExtents, results, orientation, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[5] ) ) ),
                    6 ) );

            m_Properties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(center, halfExtents, results)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ) ) ),
                    3 ) );

            m_Properties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(center, halfExtents, results)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Collider[] >( a[2] ) ) ),
                    3 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < QueryTriggerInteraction >( a[7] ) ) ),
                    8 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, results)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < RaycastHit[] >( a[3] ) ) ),
                    4 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_PhysicsScene : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_PhysicsScene() : base( typeof( PhysicsScene ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Collider : BSWrapperObject < Collider >

    {
        #region Public

        public BSWrapperObject_Collider( Collider obj ) : base( obj )
        {
            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["attachedRigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_Rigidbody( m_InternalObject.attachedRigidbody ),
                null );

            m_Properties["attachedArticulationBody"] = new BSReflectionReference(
                () => new BSWrapperObject_ArticulationBody( m_InternalObject.attachedArticulationBody ),
                null );

            m_Properties["isTrigger"] = new BSReflectionReference(
                () => m_InternalObject.isTrigger ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isTrigger = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["contactOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.contactOffset ),
                x => m_InternalObject.contactOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_Bounds( m_InternalObject.bounds ),
                null );

            m_Properties["sharedMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_PhysicMaterial( m_InternalObject.sharedMaterial ),
                x => m_InternalObject.sharedMaterial = WrapperHelper.UnwrapObject < PhysicMaterial >( x ) );

            m_Properties["material"] = new BSReflectionReference(
                () => new BSWrapperObject_PhysicMaterial( m_InternalObject.material ),
                x => m_InternalObject.material = WrapperHelper.UnwrapObject < PhysicMaterial >( x ) );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(position)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.ClosestPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ClosestPointOnBounds"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPointOnBounds(position)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.ClosestPointOnBounds( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponentInChildren"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponentInChildren(t, includeInactive)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponentInChildren(
                            WrapperHelper.UnwrapObject < Type >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_Collider : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Collider() : base( typeof( Collider ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Rigidbody : BSWrapperObject < Rigidbody >

    {
        #region Public

        public BSWrapperObject_Rigidbody( Rigidbody obj ) : base( obj )
        {
            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.velocity ),
                x => m_InternalObject.velocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["angularVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.angularVelocity ),
                x => m_InternalObject.angularVelocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["drag"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.drag ),
                x => m_InternalObject.drag = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["angularDrag"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angularDrag ),
                x => m_InternalObject.angularDrag = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["mass"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mass ),
                x => m_InternalObject.mass = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useGravity"] = new BSReflectionReference(
                () => m_InternalObject.useGravity ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useGravity = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["maxDepenetrationVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxDepenetrationVelocity ),
                x => m_InternalObject.maxDepenetrationVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["isKinematic"] = new BSReflectionReference(
                () => m_InternalObject.isKinematic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isKinematic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["freezeRotation"] = new BSReflectionReference(
                () => m_InternalObject.freezeRotation ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.freezeRotation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["centerOfMass"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.centerOfMass ),
                x => m_InternalObject.centerOfMass = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["worldCenterOfMass"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.worldCenterOfMass ),
                null );

            m_Properties["inertiaTensorRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.inertiaTensorRotation ),
                x => m_InternalObject.inertiaTensorRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["inertiaTensor"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.inertiaTensor ),
                x => m_InternalObject.inertiaTensor = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["detectCollisions"] = new BSReflectionReference(
                () => m_InternalObject.detectCollisions ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.detectCollisions = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["solverIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverIterations ),
                x => m_InternalObject.solverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sleepThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sleepThreshold ),
                x => m_InternalObject.sleepThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxAngularVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxAngularVelocity ),
                x => m_InternalObject.maxAngularVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["solverVelocityIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverVelocityIterations ),
                x => m_InternalObject.solverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sleepVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sleepVelocity ),
                x => m_InternalObject.sleepVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["sleepAngularVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sleepAngularVelocity ),
                x => m_InternalObject.sleepAngularVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useConeFriction"] = new BSReflectionReference(
                () => m_InternalObject.useConeFriction ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useConeFriction = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["solverIterationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverIterations ),
                x => m_InternalObject.solverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["solverVelocityIterationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverVelocityIterations ),
                x => m_InternalObject.solverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetRelativePointVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRelativePointVelocity(relativePoint)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.GetRelativePointVelocity( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPointVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPointVelocity(worldPoint)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.GetPointVelocity( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ClosestPointOnBounds"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPointOnBounds(position)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.ClosestPointOnBounds( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponentInChildren"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponentInChildren(t, includeInactive)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponentInChildren(
                            WrapperHelper.UnwrapObject < Type >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_Rigidbody : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Rigidbody() : base( typeof( Rigidbody ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_ArticulationBody : BSWrapperObject < ArticulationBody >

    {
        #region Public

        public BSWrapperObject_ArticulationBody( ArticulationBody obj ) : base( obj )
        {
            m_Properties["anchorPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.anchorPosition ),
                x => m_InternalObject.anchorPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["parentAnchorPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.parentAnchorPosition ),
                x => m_InternalObject.parentAnchorPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["anchorRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.anchorRotation ),
                x => m_InternalObject.anchorRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["parentAnchorRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.parentAnchorRotation ),
                x => m_InternalObject.parentAnchorRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["isRoot"] = new BSReflectionReference(
                () => m_InternalObject.isRoot ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["xDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_ArticulationDrive( m_InternalObject.xDrive ),
                x => m_InternalObject.xDrive = WrapperHelper.UnwrapObject < ArticulationDrive >( x ) );

            m_Properties["yDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_ArticulationDrive( m_InternalObject.yDrive ),
                x => m_InternalObject.yDrive = WrapperHelper.UnwrapObject < ArticulationDrive >( x ) );

            m_Properties["zDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_ArticulationDrive( m_InternalObject.zDrive ),
                x => m_InternalObject.zDrive = WrapperHelper.UnwrapObject < ArticulationDrive >( x ) );

            m_Properties["immovable"] = new BSReflectionReference(
                () => m_InternalObject.immovable ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.immovable = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useGravity"] = new BSReflectionReference(
                () => m_InternalObject.useGravity ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useGravity = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["linearDamping"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.linearDamping ),
                x => m_InternalObject.linearDamping = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["angularDamping"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angularDamping ),
                x => m_InternalObject.angularDamping = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["jointFriction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.jointFriction ),
                x => m_InternalObject.jointFriction = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.velocity ),
                x => m_InternalObject.velocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["angularVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.angularVelocity ),
                x => m_InternalObject.angularVelocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["mass"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mass ),
                x => m_InternalObject.mass = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["centerOfMass"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.centerOfMass ),
                x => m_InternalObject.centerOfMass = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["worldCenterOfMass"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.worldCenterOfMass ),
                null );

            m_Properties["inertiaTensor"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.inertiaTensor ),
                x => m_InternalObject.inertiaTensor = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["inertiaTensorRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.inertiaTensorRotation ),
                x => m_InternalObject.inertiaTensorRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["sleepThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sleepThreshold ),
                x => m_InternalObject.sleepThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["solverIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverIterations ),
                x => m_InternalObject.solverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["solverVelocityIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverVelocityIterations ),
                x => m_InternalObject.solverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["maxAngularVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxAngularVelocity ),
                x => m_InternalObject.maxAngularVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxLinearVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxLinearVelocity ),
                x => m_InternalObject.maxLinearVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxJointVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxJointVelocity ),
                x => m_InternalObject.maxJointVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxDepenetrationVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxDepenetrationVelocity ),
                x => m_InternalObject.maxDepenetrationVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["jointPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_ArticulationReducedSpace( m_InternalObject.jointPosition ),
                x => m_InternalObject.jointPosition = WrapperHelper.UnwrapObject < ArticulationReducedSpace >( x ) );

            m_Properties["jointVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_ArticulationReducedSpace( m_InternalObject.jointVelocity ),
                x => m_InternalObject.jointVelocity = WrapperHelper.UnwrapObject < ArticulationReducedSpace >( x ) );

            m_Properties["jointAcceleration"] = new BSReflectionReference(
                () => new BSWrapperObject_ArticulationReducedSpace( m_InternalObject.jointAcceleration ),
                x => m_InternalObject.jointAcceleration =
                    WrapperHelper.UnwrapObject < ArticulationReducedSpace >( x ) );

            m_Properties["jointForce"] = new BSReflectionReference(
                () => new BSWrapperObject_ArticulationReducedSpace( m_InternalObject.jointForce ),
                x => m_InternalObject.jointForce = WrapperHelper.UnwrapObject < ArticulationReducedSpace >( x ) );

            m_Properties["dofCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dofCount ),
                null );

            m_Properties["index"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.index ),
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function GetClosestPoint(point)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.GetClosestPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetRelativePointVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRelativePointVelocity(relativePoint)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.GetRelativePointVelocity( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPointVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPointVelocity(worldPoint)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.GetPointVelocity( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponentInChildren"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponentInChildren(t, includeInactive)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponentInChildren(
                            WrapperHelper.UnwrapObject < Type >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_ArticulationBody : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_ArticulationBody() : base( typeof( ArticulationBody ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_ArticulationDrive : BSWrapperObject < ArticulationDrive >

    {
        #region Public

        public BSWrapperObject_ArticulationDrive( ArticulationDrive obj ) : base( obj )
        {
            m_Properties["lowerLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lowerLimit ),
                x => m_InternalObject.lowerLimit = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["upperLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.upperLimit ),
                x => m_InternalObject.upperLimit = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["stiffness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stiffness ),
                x => m_InternalObject.stiffness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["damping"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.damping ),
                x => m_InternalObject.damping = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["forceLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.forceLimit ),
                x => m_InternalObject.forceLimit = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["target"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.target ),
                x => m_InternalObject.target = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["targetVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.targetVelocity ),
                x => m_InternalObject.targetVelocity = WrapperHelper.UnwrapObject < float >( x ) );

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

    public class BSStaticWrapperObject_ArticulationDrive : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_ArticulationDrive() : base( typeof( ArticulationDrive ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_ArticulationReducedSpace : BSWrapperObject < ArticulationReducedSpace >

    {
        #region Public

        public BSWrapperObject_ArticulationReducedSpace( ArticulationReducedSpace obj ) : base( obj )
        {
            m_Properties["dofCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dofCount ),
                x => m_InternalObject.dofCount = WrapperHelper.UnwrapObject < int >( x ) );

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

    public class BSStaticWrapperObject_ArticulationReducedSpace : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_ArticulationReducedSpace() : base( typeof( ArticulationReducedSpace ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Bounds : BSWrapperObject < Bounds >

    {
        #region Public

        public BSWrapperObject_Bounds( Bounds obj ) : base( obj )
        {
            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["extents"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.extents ),
                x => m_InternalObject.extents = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["min"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.min ),
                x => m_InternalObject.min = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["max"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.max ),
                x => m_InternalObject.max = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IntersectRay"] = new BSFunctionReference(
                new BSFunction(
                    "function IntersectRay(ray)",
                    a => m_InternalObject.IntersectRay( WrapperHelper.UnwrapObject < Ray >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format, formatProvider)",
                    a => new BSObject(
                        m_InternalObject.ToString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["SqrDistance"] = new BSFunctionReference(
                new BSFunction(
                    "function SqrDistance(point)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.SqrDistance( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(point)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.ClosestPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_Bounds : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Bounds() : base( typeof( Bounds ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Ray : BSWrapperObject < Ray >

    {
        #region Public

        public BSWrapperObject_Ray( Ray obj ) : base( obj )
        {
            m_Properties["origin"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.origin ),
                x => m_InternalObject.origin = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["direction"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.direction ),
                x => m_InternalObject.direction = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["GetPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPoint(distance)",
                    a => new BSWrapperObject_Vector3(
                        m_InternalObject.GetPoint( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

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

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format, formatProvider)",
                    a => new BSObject(
                        m_InternalObject.ToString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

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

    public class BSStaticWrapperObject_Ray : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Ray() : base( typeof( Ray ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_PhysicMaterial : BSWrapperObject < PhysicMaterial >

    {
        #region Public

        public BSWrapperObject_PhysicMaterial( PhysicMaterial obj ) : base( obj )
        {
            m_Properties["bounciness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounciness ),
                x => m_InternalObject.bounciness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["dynamicFriction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dynamicFriction ),
                x => m_InternalObject.dynamicFriction = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["staticFriction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.staticFriction ),
                x => m_InternalObject.staticFriction = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bouncyness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounciness ),
                x => m_InternalObject.bounciness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_PhysicMaterial : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_PhysicMaterial() : base( typeof( PhysicMaterial ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Time : BSWrapperObject < Time >

    {
        #region Public

        public BSWrapperObject_Time( Time obj ) : base( obj )
        {
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

    public class BSStaticWrapperObject_Time : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Time() : base( typeof( Time ) )
        {
            m_StaticProperties["time"] = new BSReflectionReference( () => new BSObject( ( decimal ) Time.time ), null );

            m_StaticProperties["timeAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.timeAsDouble ),
                null );

            m_StaticProperties["timeSinceLevelLoad"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.timeSinceLevelLoad ),
                null );

            m_StaticProperties["timeSinceLevelLoadAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.timeSinceLevelLoadAsDouble ),
                null );

            m_StaticProperties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.deltaTime ),
                null );

            m_StaticProperties["fixedTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedTime ),
                null );

            m_StaticProperties["fixedTimeAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedTimeAsDouble ),
                null );

            m_StaticProperties["unscaledTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.unscaledTime ),
                null );

            m_StaticProperties["unscaledTimeAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.unscaledTimeAsDouble ),
                null );

            m_StaticProperties["fixedUnscaledTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedUnscaledTime ),
                null );

            m_StaticProperties["fixedUnscaledTimeAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedUnscaledTimeAsDouble ),
                null );

            m_StaticProperties["unscaledDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.unscaledDeltaTime ),
                null );

            m_StaticProperties["fixedUnscaledDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedUnscaledDeltaTime ),
                null );

            m_StaticProperties["fixedDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedDeltaTime ),
                x => Time.fixedDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["maximumDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.maximumDeltaTime ),
                x => Time.maximumDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["smoothDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.smoothDeltaTime ),
                null );

            m_StaticProperties["maximumParticleDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.maximumParticleDeltaTime ),
                x => Time.maximumParticleDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["timeScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.timeScale ),
                x => Time.timeScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["frameCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.frameCount ),
                null );

            m_StaticProperties["renderedFrameCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.renderedFrameCount ),
                null );

            m_StaticProperties["realtimeSinceStartup"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.realtimeSinceStartup ),
                null );

            m_StaticProperties["realtimeSinceStartupAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.realtimeSinceStartupAsDouble ),
                null );

            m_StaticProperties["captureDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.captureDeltaTime ),
                x => Time.captureDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["captureFramerate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.captureFramerate ),
                x => Time.captureFramerate = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["inFixedTimeStep"] = new BSReflectionReference(
                () => Time.inFixedTimeStep ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

    public class BSWrapperObject_Debug : BSWrapperObject < Debug >

    {
        #region Public

        public BSWrapperObject_Debug( Debug obj ) : base( obj )
        {
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

    public class BSStaticWrapperObject_Debug : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Debug() : base( typeof( Debug ) )
        {
            m_StaticProperties["unityLogger"] = new BSReflectionReference(
                () => new BSWrapperObject_ILogger( Debug.unityLogger ),
                null );

            m_StaticProperties["developerConsoleVisible"] = new BSReflectionReference(
                () => Debug.developerConsoleVisible ? BSObject.One : BSObject.Zero,
                x => Debug.developerConsoleVisible = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["isDebugBuild"] = new BSReflectionReference(
                () => Debug.isDebugBuild ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["logger"] = new BSReflectionReference(
                () => new BSWrapperObject_ILogger( Debug.unityLogger ),
                null );

        }

        #endregion
    }

    public class BSWrapperObject_ILogger : BSWrapperObject < ILogger >

    {
        #region Public

        public BSWrapperObject_ILogger( ILogger obj ) : base( obj )
        {
            m_Properties["logHandler"] = new BSReflectionReference(
                () => new BSWrapperObject_ILogHandler( m_InternalObject.logHandler ),
                x => m_InternalObject.logHandler = WrapperHelper.UnwrapObject < ILogHandler >( x ) );

            m_Properties["logEnabled"] = new BSReflectionReference(
                () => m_InternalObject.logEnabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.logEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_ILogger : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_ILogger() : base( typeof( ILogger ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_ILogHandler : BSWrapperObject < ILogHandler >

    {
        #region Public

        public BSWrapperObject_ILogHandler( ILogHandler obj ) : base( obj )
        {

        }

        #endregion
    }

    public class BSStaticWrapperObject_ILogHandler : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_ILogHandler() : base( typeof( ILogHandler ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Input : BSWrapperObject < Input >

    {
        #region Public

        public BSWrapperObject_Input( Input obj ) : base( obj )
        {
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

    public class BSStaticWrapperObject_Input : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Input() : base( typeof( Input ) )
        {
            m_StaticProperties["simulateMouseWithTouches"] = new BSReflectionReference(
                () => Input.simulateMouseWithTouches ? BSObject.One : BSObject.Zero,
                x => Input.simulateMouseWithTouches = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["anyKey"] = new BSReflectionReference(
                () => Input.anyKey ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["anyKeyDown"] = new BSReflectionReference(
                () => Input.anyKeyDown ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["inputString"] =
                new BSReflectionReference( () => new BSObject( Input.inputString ), null );

            m_StaticProperties["mousePosition"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( Input.mousePosition ),
                null );

            m_StaticProperties["mouseScrollDelta"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( Input.mouseScrollDelta ),
                null );

            m_StaticProperties["compositionString"] = new BSReflectionReference(
                () => new BSObject( Input.compositionString ),
                null );

            m_StaticProperties["imeIsSelected"] = new BSReflectionReference(
                () => Input.imeIsSelected ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["compositionCursorPos"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( Input.compositionCursorPos ),
                x => Input.compositionCursorPos = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_StaticProperties["eatKeyPressOnTextFieldFocus"] = new BSReflectionReference(
                () => Input.eatKeyPressOnTextFieldFocus ? BSObject.One : BSObject.Zero,
                x => Input.eatKeyPressOnTextFieldFocus = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["mousePresent"] = new BSReflectionReference(
                () => Input.mousePresent ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["touchCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Input.touchCount ),
                null );

            m_StaticProperties["touchPressureSupported"] = new BSReflectionReference(
                () => Input.touchPressureSupported ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["stylusTouchSupported"] = new BSReflectionReference(
                () => Input.stylusTouchSupported ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["touchSupported"] = new BSReflectionReference(
                () => Input.touchSupported ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["multiTouchEnabled"] = new BSReflectionReference(
                () => Input.multiTouchEnabled ? BSObject.One : BSObject.Zero,
                x => Input.multiTouchEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["isGyroAvailable"] = new BSReflectionReference(
                () => Input.isGyroAvailable ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["acceleration"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( Input.acceleration ),
                null );

            m_StaticProperties["compensateSensors"] = new BSReflectionReference(
                () => Input.compensateSensors ? BSObject.One : BSObject.Zero,
                x => Input.compensateSensors = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["accelerationEventCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Input.accelerationEventCount ),
                null );

            m_StaticProperties["backButtonLeavesApp"] = new BSReflectionReference(
                () => Input.backButtonLeavesApp ? BSObject.One : BSObject.Zero,
                x => Input.backButtonLeavesApp = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["location"] = new BSReflectionReference(
                () => new BSWrapperObject_LocationService( Input.location ),
                null );

            m_StaticProperties["compass"] = new BSReflectionReference(
                () => new BSWrapperObject_Compass( Input.compass ),
                null );

            m_StaticProperties["gyro"] = new BSReflectionReference(
                () => new BSWrapperObject_Gyroscope( Input.gyro ),
                null );

            m_StaticProperties["GetAxis"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAxis(axisName)",
                    a => new BSObject( ( decimal ) Input.GetAxis( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAxisRaw"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAxisRaw(axisName)",
                    a => new BSObject( ( decimal ) Input.GetAxisRaw( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetButton"] = new BSFunctionReference(
                new BSFunction(
                    "function GetButton(buttonName)",
                    a => Input.GetButton( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetButtonDown"] = new BSFunctionReference(
                new BSFunction(
                    "function GetButtonDown(buttonName)",
                    a => Input.GetButtonDown( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetButtonUp"] = new BSFunctionReference(
                new BSFunction(
                    "function GetButtonUp(buttonName)",
                    a => Input.GetButtonUp( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetMouseButton"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButton(button)",
                    a => Input.GetMouseButton( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetMouseButtonDown"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButtonDown(button)",
                    a => Input.GetMouseButtonDown( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetMouseButtonUp"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButtonUp(button)",
                    a => Input.GetMouseButtonUp( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsJoystickPreconfigured"] = new BSFunctionReference(
                new BSFunction(
                    "function IsJoystickPreconfigured(joystickName)",
                    a => Input.IsJoystickPreconfigured( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetTouch"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTouch(index)",
                    a => new BSWrapperObject_Touch( Input.GetTouch( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAccelerationEvent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAccelerationEvent(index)",
                    a => new BSWrapperObject_AccelerationEvent(
                        Input.GetAccelerationEvent( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetKey"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKey(name)",
                    a => Input.GetKey( WrapperHelper.UnwrapObject < string >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetKeyUp"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKeyUp(name)",
                    a => Input.GetKeyUp( WrapperHelper.UnwrapObject < string >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetKeyDown"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKeyDown(name)",
                    a => Input.GetKeyDown( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSWrapperObject_Vector2 : BSWrapperObject < Vector2 >

    {
        #region Public

        public BSWrapperObject_Vector2( Vector2 obj ) : base( obj )
        {
            m_Properties["magnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.magnitude ),
                null );

            m_Properties["sqrMagnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sqrMagnitude ),
                null );

            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < float >( x ) );

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

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format, formatProvider)",
                    a => new BSObject(
                        m_InternalObject.ToString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_Vector2 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Vector2() : base( typeof( Vector2 ) )
        {
            m_StaticProperties["kEpsilon"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vector2.kEpsilon ),
                null );

            m_StaticProperties["kEpsilonNormalSqrt"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vector2.kEpsilonNormalSqrt ),
                null );

        }

        #endregion
    }

    public class BSWrapperObject_LocationService : BSWrapperObject < LocationService >

    {
        #region Public

        public BSWrapperObject_LocationService( LocationService obj ) : base( obj )
        {
            m_Properties["isEnabledByUser"] = new BSReflectionReference(
                () => m_InternalObject.isEnabledByUser ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["lastData"] = new BSReflectionReference(
                () => new BSWrapperObject_LocationInfo( m_InternalObject.lastData ),
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

    public class BSStaticWrapperObject_LocationService : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_LocationService() : base( typeof( LocationService ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_LocationInfo : BSWrapperObject < LocationInfo >

    {
        #region Public

        public BSWrapperObject_LocationInfo( LocationInfo obj ) : base( obj )
        {
            m_Properties["latitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.latitude ),
                null );

            m_Properties["longitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.longitude ),
                null );

            m_Properties["altitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.altitude ),
                null );

            m_Properties["horizontalAccuracy"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.horizontalAccuracy ),
                null );

            m_Properties["verticalAccuracy"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.verticalAccuracy ),
                null );

            m_Properties["timestamp"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.timestamp ),
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

    public class BSStaticWrapperObject_LocationInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_LocationInfo() : base( typeof( LocationInfo ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Compass : BSWrapperObject < Compass >

    {
        #region Public

        public BSWrapperObject_Compass( Compass obj ) : base( obj )
        {
            m_Properties["magneticHeading"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.magneticHeading ),
                null );

            m_Properties["trueHeading"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.trueHeading ),
                null );

            m_Properties["headingAccuracy"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.headingAccuracy ),
                null );

            m_Properties["rawVector"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.rawVector ),
                null );

            m_Properties["timestamp"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.timestamp ),
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

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

    public class BSStaticWrapperObject_Compass : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Compass() : base( typeof( Compass ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Gyroscope : BSWrapperObject < Gyroscope >

    {
        #region Public

        public BSWrapperObject_Gyroscope( Gyroscope obj ) : base( obj )
        {
            m_Properties["rotationRate"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.rotationRate ),
                null );

            m_Properties["rotationRateUnbiased"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.rotationRateUnbiased ),
                null );

            m_Properties["gravity"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.gravity ),
                null );

            m_Properties["userAcceleration"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.userAcceleration ),
                null );

            m_Properties["attitude"] = new BSReflectionReference(
                () => new BSWrapperObject_Quaternion( m_InternalObject.attitude ),
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["updateInterval"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.updateInterval ),
                x => m_InternalObject.updateInterval = WrapperHelper.UnwrapObject < float >( x ) );

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

    public class BSStaticWrapperObject_Gyroscope : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Gyroscope() : base( typeof( Gyroscope ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Touch : BSWrapperObject < Touch >

    {
        #region Public

        public BSWrapperObject_Touch( Touch obj ) : base( obj )
        {
            m_Properties["fingerId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fingerId ),
                x => m_InternalObject.fingerId = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["rawPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( m_InternalObject.rawPosition ),
                x => m_InternalObject.rawPosition = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["deltaPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( m_InternalObject.deltaPosition ),
                x => m_InternalObject.deltaPosition = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.deltaTime ),
                x => m_InternalObject.deltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["tapCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tapCount ),
                x => m_InternalObject.tapCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["pressure"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pressure ),
                x => m_InternalObject.pressure = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maximumPossiblePressure"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maximumPossiblePressure ),
                x => m_InternalObject.maximumPossiblePressure = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["altitudeAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.altitudeAngle ),
                x => m_InternalObject.altitudeAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["azimuthAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.azimuthAngle ),
                x => m_InternalObject.azimuthAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["radius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.radius ),
                x => m_InternalObject.radius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["radiusVariance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.radiusVariance ),
                x => m_InternalObject.radiusVariance = WrapperHelper.UnwrapObject < float >( x ) );

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

    public class BSStaticWrapperObject_Touch : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Touch() : base( typeof( Touch ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_AccelerationEvent : BSWrapperObject < AccelerationEvent >

    {
        #region Public

        public BSWrapperObject_AccelerationEvent( AccelerationEvent obj ) : base( obj )
        {
            m_Properties["acceleration"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector3( m_InternalObject.acceleration ),
                null );

            m_Properties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.deltaTime ),
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

    public class BSStaticWrapperObject_AccelerationEvent : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_AccelerationEvent() : base( typeof( AccelerationEvent ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Screen : BSWrapperObject < Screen >

    {
        #region Public

        public BSWrapperObject_Screen( Screen obj ) : base( obj )
        {
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

    public class BSStaticWrapperObject_Screen : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Screen() : base( typeof( Screen ) )
        {
            m_StaticProperties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Screen.width ),
                null );

            m_StaticProperties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Screen.height ),
                null );

            m_StaticProperties["dpi"] = new BSReflectionReference( () => new BSObject( ( decimal ) Screen.dpi ), null );

            m_StaticProperties["currentResolution"] = new BSReflectionReference(
                () => new BSWrapperObject_Resolution( Screen.currentResolution ),
                null );

            m_StaticProperties["fullScreen"] = new BSReflectionReference(
                () => Screen.fullScreen ? BSObject.One : BSObject.Zero,
                x => Screen.fullScreen = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["safeArea"] = new BSReflectionReference(
                () => new BSWrapperObject_Rect( Screen.safeArea ),
                null );

            m_StaticProperties["autorotateToPortrait"] = new BSReflectionReference(
                () => Screen.autorotateToPortrait ? BSObject.One : BSObject.Zero,
                x => Screen.autorotateToPortrait = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autorotateToPortraitUpsideDown"] = new BSReflectionReference(
                () => Screen.autorotateToPortraitUpsideDown ? BSObject.One : BSObject.Zero,
                x => Screen.autorotateToPortraitUpsideDown = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autorotateToLandscapeLeft"] = new BSReflectionReference(
                () => Screen.autorotateToLandscapeLeft ? BSObject.One : BSObject.Zero,
                x => Screen.autorotateToLandscapeLeft = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autorotateToLandscapeRight"] = new BSReflectionReference(
                () => Screen.autorotateToLandscapeRight ? BSObject.One : BSObject.Zero,
                x => Screen.autorotateToLandscapeRight = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["sleepTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Screen.sleepTimeout ),
                x => Screen.sleepTimeout = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["brightness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Screen.brightness ),
                x => Screen.brightness = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["lockCursor"] = new BSReflectionReference(
                () => Screen.lockCursor ? BSObject.One : BSObject.Zero,
                x => Screen.lockCursor = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

    public class BSWrapperObject_Resolution : BSWrapperObject < Resolution >

    {
        #region Public

        public BSWrapperObject_Resolution( Resolution obj ) : base( obj )
        {
            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["refreshRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.refreshRate ),
                x => m_InternalObject.refreshRate = WrapperHelper.UnwrapObject < int >( x ) );

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

    public class BSStaticWrapperObject_Resolution : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Resolution() : base( typeof( Resolution ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Rect : BSWrapperObject < Rect >

    {
        #region Public

        public BSWrapperObject_Rect( Rect obj ) : base( obj )
        {
            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["min"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( m_InternalObject.min ),
                x => m_InternalObject.min = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["max"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( m_InternalObject.max ),
                x => m_InternalObject.max = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_Vector2( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["xMin"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.xMin ),
                x => m_InternalObject.xMin = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["yMin"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.yMin ),
                x => m_InternalObject.yMin = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["xMax"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.xMax ),
                x => m_InternalObject.xMax = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["yMax"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.yMax ),
                x => m_InternalObject.yMax = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["left"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.left ),
                null );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.right ),
                null );

            m_Properties["top"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.top ),
                null );

            m_Properties["bottom"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bottom ),
                null );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point, allowInverse)",
                    a => m_InternalObject.Contains(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point, allowInverse)",
                    a => m_InternalObject.Contains(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["Overlaps"] = new BSFunctionReference(
                new BSFunction(
                    "function Overlaps(other, allowInverse)",
                    a => m_InternalObject.Overlaps(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

    public class BSStaticWrapperObject_Rect : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Rect() : base( typeof( Rect ) )
        {
            m_StaticProperties["NormalizedToPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function NormalizedToPoint(rectangle, normalizedRectCoordinates)",
                    a => new BSWrapperObject_Vector2(
                        Rect.NormalizedToPoint(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["PointToNormalized"] = new BSFunctionReference(
                new BSFunction(
                    "function PointToNormalized(rectangle, point)",
                    a => new BSWrapperObject_Vector2(
                        Rect.PointToNormalized(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

    public class BSWrapperObject_MeshFilter : BSWrapperObject < MeshFilter >

    {
        #region Public

        public BSWrapperObject_MeshFilter( MeshFilter obj ) : base( obj )
        {
            m_Properties["sharedMesh"] = new BSReflectionReference(
                () => new BSWrapperObject_Mesh( m_InternalObject.sharedMesh ),
                x => m_InternalObject.sharedMesh = WrapperHelper.UnwrapObject < Mesh >( x ) );

            m_Properties["mesh"] = new BSReflectionReference(
                () => new BSWrapperObject_Mesh( m_InternalObject.mesh ),
                x => m_InternalObject.mesh = WrapperHelper.UnwrapObject < Mesh >( x ) );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponentInChildren"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponentInChildren(t, includeInactive)",
                    a => new BSWrapperObject_Component(
                        m_InternalObject.GetComponentInChildren(
                            WrapperHelper.UnwrapObject < Type >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_MeshFilter : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_MeshFilter() : base( typeof( MeshFilter ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_Mesh : BSWrapperObject < Mesh >

    {
        #region Public

        public BSWrapperObject_Mesh( Mesh obj ) : base( obj )
        {
            m_Properties["vertexBufferCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexBufferCount ),
                null );

            m_Properties["blendShapeCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.blendShapeCount ),
                null );

            m_Properties["isReadable"] = new BSReflectionReference(
                () => m_InternalObject.isReadable ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                null );

            m_Properties["subMeshCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.subMeshCount ),
                x => m_InternalObject.subMeshCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_Bounds( m_InternalObject.bounds ),
                x => m_InternalObject.bounds = WrapperHelper.UnwrapObject < Bounds >( x ) );

            m_Properties["vertexAttributeCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexAttributeCount ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetVertexAttribute"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVertexAttribute(index)",
                    a => new BSWrapperObject_VertexAttributeDescriptor(
                        m_InternalObject.GetVertexAttribute( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetNativeVertexBufferPtr"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNativeVertexBufferPtr(index)",
                    a => new BSWrapperObject_IntPtr(
                        m_InternalObject.GetNativeVertexBufferPtr( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBlendShapeName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeName(shapeIndex)",
                    a => new BSObject(
                        m_InternalObject.GetBlendShapeName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBlendShapeIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeIndex(blendShapeName)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBlendShapeIndex(
                            WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBlendShapeFrameCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeFrameCount(shapeIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBlendShapeFrameCount(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBlendShapeFrameWeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeFrameWeight(shapeIndex, frameIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBlendShapeFrameWeight(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetBlendShapeFrameWeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeFrameWeight(shapeIndex, frameIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBlendShapeFrameWeight(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetSubMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSubMesh(index)",
                    a => new BSWrapperObject_SubMeshDescriptor(
                        m_InternalObject.GetSubMesh( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUVDistributionMetric"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUVDistributionMetric(uvSetIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUVDistributionMetric(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetIndexStart"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIndexStart(submesh)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetIndexStart( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetIndexCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIndexCount(submesh)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetIndexCount( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBaseVertex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBaseVertex(submesh)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBaseVertex( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_Mesh : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Mesh() : base( typeof( Mesh ) )
        {
            m_StaticProperties["AllocateWritableMeshData"] = new BSFunctionReference(
                new BSFunction(
                    "function AllocateWritableMeshData(meshCount)",
                    a => new BSWrapperObject_MeshDataArray(
                        Mesh.AllocateWritableMeshData( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

    public class BSWrapperObject_VertexAttributeDescriptor : BSWrapperObject < VertexAttributeDescriptor >

    {
        #region Public

        public BSWrapperObject_VertexAttributeDescriptor( VertexAttributeDescriptor obj ) : base( obj )
        {
            m_Properties["dimension"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dimension ),
                x => m_InternalObject.dimension = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["stream"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stream ),
                x => m_InternalObject.stream = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_VertexAttributeDescriptor : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_VertexAttributeDescriptor() : base( typeof( VertexAttributeDescriptor ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_IntPtr : BSWrapperObject < IntPtr >

    {
        #region Public

        public BSWrapperObject_IntPtr( IntPtr obj ) : base( obj )
        {
            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format)",
                    a => new BSObject( m_InternalObject.ToString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

    public class BSStaticWrapperObject_IntPtr : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_IntPtr() : base( typeof( IntPtr ) )
        {
            m_StaticProperties["Size"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) IntPtr.Size ),
                null );

        }

        #endregion
    }

    public class BSWrapperObject_SubMeshDescriptor : BSWrapperObject < SubMeshDescriptor >

    {
        #region Public

        public BSWrapperObject_SubMeshDescriptor( SubMeshDescriptor obj ) : base( obj )
        {
            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_Bounds( m_InternalObject.bounds ),
                x => m_InternalObject.bounds = WrapperHelper.UnwrapObject < Bounds >( x ) );

            m_Properties["indexStart"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indexStart ),
                x => m_InternalObject.indexStart = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["indexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indexCount ),
                x => m_InternalObject.indexCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["baseVertex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.baseVertex ),
                x => m_InternalObject.baseVertex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["firstVertex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.firstVertex ),
                x => m_InternalObject.firstVertex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                x => m_InternalObject.vertexCount = WrapperHelper.UnwrapObject < int >( x ) );

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

    public class BSStaticWrapperObject_SubMeshDescriptor : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_SubMeshDescriptor() : base( typeof( SubMeshDescriptor ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_MeshDataArray : BSWrapperObject < Mesh.MeshDataArray >

    {
        #region Public

        public BSWrapperObject_MeshDataArray( Mesh.MeshDataArray obj ) : base( obj )
        {
            m_Properties["Length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Length ),
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

    public class BSStaticWrapperObject_MeshDataArray : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_MeshDataArray() : base( typeof( Mesh.MeshDataArray ) )
        {

        }

        #endregion
    }

    public class BSWrapperObject_MeshData : BSWrapperObject < Mesh.MeshData >

    {
        #region Public

        public BSWrapperObject_MeshData( Mesh.MeshData obj ) : base( obj )
        {
            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                null );

            m_Properties["vertexBufferCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexBufferCount ),
                null );

            m_Properties["subMeshCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.subMeshCount ),
                x => m_InternalObject.subMeshCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["GetSubMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSubMesh(index)",
                    a => new BSWrapperObject_SubMeshDescriptor(
                        m_InternalObject.GetSubMesh( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

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

    public class BSStaticWrapperObject_MeshData : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_MeshData() : base( typeof( Mesh.MeshData ) )
        {

        }

        #endregion
    }

    public class BadScriptCTorDB : IWrapperConstructorDataBase
    {
        private readonly Dictionary < Type, (IWrapperObjectCreator[], Func < object[], object >) > m_Creators;

        public Type[] Types => m_Creators.Keys.ToArray();

        #region Public

        public BadScriptCTorDB()
        {
            m_Creators = new Dictionary < Type, (IWrapperObjectCreator[], Func < object[], object >) >
            {
                {
                    typeof( GameObject ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_GameObject(
                          ( GameObject ) m_Creators[typeof( GameObject )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Transform ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Transform(
                          ( Transform ) m_Creators[typeof( Transform )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Vector3 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Vector3(
                          ( Vector3 ) m_Creators[typeof( Vector3 )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( object ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Object(
                          ( object ) m_Creators[typeof( object )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( IFormatProvider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_IFormatProvider(
                          ( IFormatProvider ) m_Creators[typeof( IFormatProvider )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( Quaternion ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Quaternion(
                          ( Quaternion ) m_Creators[typeof( Quaternion )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Matrix4x4 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Matrix4x4(
                          ( Matrix4x4 ) m_Creators[typeof( Matrix4x4 )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( FrustumPlanes ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_FrustumPlanes(
                          ( FrustumPlanes ) m_Creators[typeof( FrustumPlanes )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Vector4 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Vector4(
                          ( Vector4 ) m_Creators[typeof( Vector4 )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( Plane ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Plane(
                          ( Plane ) m_Creators[typeof( Plane )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( IEnumerator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_IEnumerator(
                          ( IEnumerator ) m_Creators[typeof( IEnumerator )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Component ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Component(
                          ( Component ) m_Creators[typeof( Component )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Scene ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Scene(
                          ( Scene ) m_Creators[typeof( Scene )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( MonoBehaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_MonoBehaviour(
                          ( MonoBehaviour ) m_Creators[typeof( MonoBehaviour )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Coroutine ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Coroutine(
                          ( Coroutine ) m_Creators[typeof( Coroutine )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Physics ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Physics(
                          ( Physics ) m_Creators[typeof( Physics )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( PhysicsScene ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_PhysicsScene(
                          ( PhysicsScene ) m_Creators[typeof( PhysicsScene )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Collider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Collider(
                          ( Collider ) m_Creators[typeof( Collider )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( Rigidbody ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Rigidbody(
                          ( Rigidbody ) m_Creators[typeof( Rigidbody )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( ArticulationBody ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_ArticulationBody(
                          ( ArticulationBody ) m_Creators[typeof( ArticulationBody )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( ArticulationDrive ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_ArticulationDrive(
                          ( ArticulationDrive ) m_Creators[typeof( ArticulationDrive )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ArticulationReducedSpace ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_ArticulationReducedSpace(
                          ( ArticulationReducedSpace ) m_Creators[typeof( ArticulationReducedSpace )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( Bounds ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Bounds(
                          ( Bounds ) m_Creators[typeof( Bounds )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Ray ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Ray(
                          ( Ray ) m_Creators[typeof( Ray )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( PhysicMaterial ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_PhysicMaterial(
                          ( PhysicMaterial ) m_Creators[typeof( PhysicMaterial )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( Time ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Time(
                          ( Time ) m_Creators[typeof( Time )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( Debug ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Debug(
                          ( Debug ) m_Creators[typeof( Debug )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( ILogger ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_ILogger(
                          ( ILogger ) m_Creators[typeof( ILogger )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( ILogHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_ILogHandler(
                          ( ILogHandler ) m_Creators[typeof( ILogHandler )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Input ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Input(
                          ( Input ) m_Creators[typeof( Input )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( Vector2 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Vector2(
                          ( Vector2 ) m_Creators[typeof( Vector2 )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( LocationService ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_LocationService(
                          ( LocationService ) m_Creators[typeof( LocationService )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( LocationInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_LocationInfo(
                          ( LocationInfo ) m_Creators[typeof( LocationInfo )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Compass ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Compass(
                          ( Compass ) m_Creators[typeof( Compass )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( Gyroscope ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Gyroscope(
                          ( Gyroscope ) m_Creators[typeof( Gyroscope )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Touch ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Touch(
                          ( Touch ) m_Creators[typeof( Touch )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( AccelerationEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_AccelerationEvent(
                          ( AccelerationEvent ) m_Creators[typeof( AccelerationEvent )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Screen ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Screen(
                          ( Screen ) m_Creators[typeof( Screen )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Resolution ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Resolution(
                          ( Resolution ) m_Creators[typeof( Resolution )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Rect ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Rect(
                          ( Rect ) m_Creators[typeof( Rect )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( MeshFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_MeshFilter(
                          ( MeshFilter ) m_Creators[typeof( MeshFilter )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Mesh ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Mesh(
                          ( Mesh ) m_Creators[typeof( Mesh )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( VertexAttributeDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_VertexAttributeDescriptor(
                          ( VertexAttributeDescriptor ) m_Creators[typeof( VertexAttributeDescriptor )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( IntPtr ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_IntPtr(
                          ( IntPtr ) m_Creators[typeof( IntPtr )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( SubMeshDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_SubMeshDescriptor(
                          ( SubMeshDescriptor ) m_Creators[typeof( SubMeshDescriptor )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Mesh.MeshDataArray ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_MeshDataArray(
                          ( Mesh.MeshDataArray ) m_Creators[typeof( Mesh.MeshDataArray )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( Mesh.MeshData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_MeshData(
                          ( Mesh.MeshData ) m_Creators[typeof( Mesh.MeshData )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },

            };
        }

        public ABSObject Get( Type t, object[] args )
        {
            return ( ABSObject ) m_Creators[t].Item2( args );
        }

        public bool HasType < T >()
        {
            return m_Creators.ContainsKey( typeof( T ) );
        }

        #endregion
    }

    public class BadScriptStaticDB : WrapperStaticDataBase
    {
        #region Public

        public BadScriptStaticDB()
        {
            StaticTypes[typeof( GameObject )] = new BSStaticWrapperObject_GameObject();
            StaticTypes[typeof( Transform )] = new BSStaticWrapperObject_Transform();
            StaticTypes[typeof( Vector3 )] = new BSStaticWrapperObject_Vector3();
            StaticTypes[typeof( object )] = new BSStaticWrapperObject_Object();
            StaticTypes[typeof( IFormatProvider )] = new BSStaticWrapperObject_IFormatProvider();
            StaticTypes[typeof( Quaternion )] = new BSStaticWrapperObject_Quaternion();
            StaticTypes[typeof( Matrix4x4 )] = new BSStaticWrapperObject_Matrix4x4();
            StaticTypes[typeof( FrustumPlanes )] = new BSStaticWrapperObject_FrustumPlanes();
            StaticTypes[typeof( Vector4 )] = new BSStaticWrapperObject_Vector4();
            StaticTypes[typeof( Plane )] = new BSStaticWrapperObject_Plane();
            StaticTypes[typeof( IEnumerator )] = new BSStaticWrapperObject_IEnumerator();
            StaticTypes[typeof( Component )] = new BSStaticWrapperObject_Component();
            StaticTypes[typeof( Scene )] = new BSStaticWrapperObject_Scene();
            StaticTypes[typeof( MonoBehaviour )] = new BSStaticWrapperObject_MonoBehaviour();
            StaticTypes[typeof( Coroutine )] = new BSStaticWrapperObject_Coroutine();
            StaticTypes[typeof( Physics )] = new BSStaticWrapperObject_Physics();
            StaticTypes[typeof( PhysicsScene )] = new BSStaticWrapperObject_PhysicsScene();
            StaticTypes[typeof( Collider )] = new BSStaticWrapperObject_Collider();
            StaticTypes[typeof( Rigidbody )] = new BSStaticWrapperObject_Rigidbody();
            StaticTypes[typeof( ArticulationBody )] = new BSStaticWrapperObject_ArticulationBody();
            StaticTypes[typeof( ArticulationDrive )] = new BSStaticWrapperObject_ArticulationDrive();
            StaticTypes[typeof( ArticulationReducedSpace )] = new BSStaticWrapperObject_ArticulationReducedSpace();
            StaticTypes[typeof( Bounds )] = new BSStaticWrapperObject_Bounds();
            StaticTypes[typeof( Ray )] = new BSStaticWrapperObject_Ray();
            StaticTypes[typeof( PhysicMaterial )] = new BSStaticWrapperObject_PhysicMaterial();
            StaticTypes[typeof( Time )] = new BSStaticWrapperObject_Time();
            StaticTypes[typeof( Debug )] = new BSStaticWrapperObject_Debug();
            StaticTypes[typeof( ILogger )] = new BSStaticWrapperObject_ILogger();
            StaticTypes[typeof( ILogHandler )] = new BSStaticWrapperObject_ILogHandler();
            StaticTypes[typeof( Input )] = new BSStaticWrapperObject_Input();
            StaticTypes[typeof( Vector2 )] = new BSStaticWrapperObject_Vector2();
            StaticTypes[typeof( LocationService )] = new BSStaticWrapperObject_LocationService();
            StaticTypes[typeof( LocationInfo )] = new BSStaticWrapperObject_LocationInfo();
            StaticTypes[typeof( Compass )] = new BSStaticWrapperObject_Compass();
            StaticTypes[typeof( Gyroscope )] = new BSStaticWrapperObject_Gyroscope();
            StaticTypes[typeof( Touch )] = new BSStaticWrapperObject_Touch();
            StaticTypes[typeof( AccelerationEvent )] = new BSStaticWrapperObject_AccelerationEvent();
            StaticTypes[typeof( Screen )] = new BSStaticWrapperObject_Screen();
            StaticTypes[typeof( Resolution )] = new BSStaticWrapperObject_Resolution();
            StaticTypes[typeof( Rect )] = new BSStaticWrapperObject_Rect();
            StaticTypes[typeof( MeshFilter )] = new BSStaticWrapperObject_MeshFilter();
            StaticTypes[typeof( Mesh )] = new BSStaticWrapperObject_Mesh();
            StaticTypes[typeof( VertexAttributeDescriptor )] = new BSStaticWrapperObject_VertexAttributeDescriptor();
            StaticTypes[typeof( IntPtr )] = new BSStaticWrapperObject_IntPtr();
            StaticTypes[typeof( SubMeshDescriptor )] = new BSStaticWrapperObject_SubMeshDescriptor();
            StaticTypes[typeof( Mesh.MeshDataArray )] = new BSStaticWrapperObject_MeshDataArray();
            StaticTypes[typeof( Mesh.MeshData )] = new BSStaticWrapperObject_MeshData();

        }

        #endregion
    }

}

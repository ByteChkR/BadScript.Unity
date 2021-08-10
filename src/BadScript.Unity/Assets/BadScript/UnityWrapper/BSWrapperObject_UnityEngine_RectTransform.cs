using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_RectTransform : BSWrapperObject < RectTransform >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RectTransform( RectTransform obj ) : base( obj )
        {
            m_Properties["rect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.rect ),
                null );

            m_Properties["anchorMin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.anchorMin ),
                x => m_InternalObject.anchorMin = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["anchorMax"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.anchorMax ),
                x => m_InternalObject.anchorMax = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["anchoredPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.anchoredPosition ),
                x => m_InternalObject.anchoredPosition = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["sizeDelta"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.sizeDelta ),
                x => m_InternalObject.sizeDelta = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["pivot"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.pivot ),
                x => m_InternalObject.pivot = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["anchoredPosition3D"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.anchoredPosition3D ),
                x => m_InternalObject.anchoredPosition3D = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["offsetMin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.offsetMin ),
                x => m_InternalObject.offsetMin = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["offsetMax"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.offsetMax ),
                x => m_InternalObject.offsetMax = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["localPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.localPosition ),
                x => m_InternalObject.localPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["eulerAngles"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.eulerAngles ),
                x => m_InternalObject.eulerAngles = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["localEulerAngles"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.localEulerAngles ),
                x => m_InternalObject.localEulerAngles = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.right ),
                x => m_InternalObject.right = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["up"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.up ),
                x => m_InternalObject.up = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["forward"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.forward ),
                x => m_InternalObject.forward = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["localRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.localRotation ),
                x => m_InternalObject.localRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["localScale"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.localScale ),
                x => m_InternalObject.localScale = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["parent"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.parent ),
                x => m_InternalObject.parent = WrapperHelper.UnwrapObject < Transform >( x ) );

            m_Properties["worldToLocalMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.worldToLocalMatrix ),
                null );

            m_Properties["localToWorldMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.localToWorldMatrix ),
                null );

            m_Properties["root"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.root ),
                null );

            m_Properties["childCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.childCount ),
                null );

            m_Properties["lossyScale"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.lossyScale ),
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

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
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
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.TransformDirection( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["TransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformDirection(x, y, z)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.TransformDirection(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformDirection(direction)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.InverseTransformDirection( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["InverseTransformDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformDirection(x, y, z)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.InverseTransformDirection(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformVector(vector)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.TransformVector( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["TransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformVector(x, y, z)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.TransformVector(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformVector(vector)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.InverseTransformVector( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["InverseTransformVector"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformVector(x, y, z)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.InverseTransformVector(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["TransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.TransformPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["TransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function TransformPoint(x, y, z)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.TransformPoint(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["InverseTransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.InverseTransformPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["InverseTransformPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseTransformPoint(x, y, z)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.InverseTransformPoint(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_Properties["Find"] = new BSFunctionReference(
                new BSFunction(
                    "function Find(n)",
                    a => new BSWrapperObject_UnityEngine_Transform(
                        m_InternalObject.Find( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsChildOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IsChildOf(parent)",
                    a => m_InternalObject.IsChildOf( WrapperHelper.UnwrapObject < Transform >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["FindChild"] = new BSFunctionReference(
                new BSFunction(
                    "function FindChild(n)",
                    a => new BSWrapperObject_UnityEngine_Transform(
                        m_InternalObject.Find( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetChild"] = new BSFunctionReference(
                new BSFunction(
                    "function GetChild(index)",
                    a => new BSWrapperObject_UnityEngine_Transform(
                        m_InternalObject.GetChild( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

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

}

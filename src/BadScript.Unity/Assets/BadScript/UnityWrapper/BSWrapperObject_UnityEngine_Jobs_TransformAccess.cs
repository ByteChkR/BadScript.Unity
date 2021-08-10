using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Jobs;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Jobs_TransformAccess : BSWrapperObject < TransformAccess >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Jobs_TransformAccess( TransformAccess obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["localPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.localPosition ),
                x => m_InternalObject.localPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["localRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.localRotation ),
                x => m_InternalObject.localRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["localScale"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.localScale ),
                x => m_InternalObject.localScale = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["localToWorldMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.localToWorldMatrix ),
                null );

            m_Properties["worldToLocalMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.worldToLocalMatrix ),
                null );

            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
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

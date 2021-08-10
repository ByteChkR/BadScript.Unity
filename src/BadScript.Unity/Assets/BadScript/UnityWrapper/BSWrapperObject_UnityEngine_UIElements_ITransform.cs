using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_ITransform : BSWrapperObject < ITransform >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_ITransform( ITransform obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["scale"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.scale ),
                x => m_InternalObject.scale = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["matrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.matrix ),
                null );

        }

        #endregion
    }

}

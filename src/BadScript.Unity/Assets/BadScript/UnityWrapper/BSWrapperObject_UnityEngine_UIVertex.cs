using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIVertex : BSWrapperObject < UIVertex >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIVertex( UIVertex obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.normal ),
                x => m_InternalObject.normal = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["tangent"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.tangent ),
                x => m_InternalObject.tangent = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color32( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color32 >( x ) );

            m_Properties["uv0"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.uv0 ),
                x => m_InternalObject.uv0 = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["uv1"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.uv1 ),
                x => m_InternalObject.uv1 = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["uv2"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.uv2 ),
                x => m_InternalObject.uv2 = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["uv3"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.uv3 ),
                x => m_InternalObject.uv3 = WrapperHelper.UnwrapObject < Vector4 >( x ) );

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

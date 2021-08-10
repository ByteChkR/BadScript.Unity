using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Rendering_VisibleReflectionProbe : BSWrapperObject < VisibleReflectionProbe >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_VisibleReflectionProbe( VisibleReflectionProbe obj ) : base( obj )
        {
            m_Properties["texture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.texture ),
                null );

            m_Properties["reflectionProbe"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ReflectionProbe( m_InternalObject.reflectionProbe ),
                null );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                x => m_InternalObject.bounds = WrapperHelper.UnwrapObject < Bounds >( x ) );

            m_Properties["localToWorldMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.localToWorldMatrix ),
                x => m_InternalObject.localToWorldMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["hdrData"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.hdrData ),
                x => m_InternalObject.hdrData = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["blendDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.blendDistance ),
                x => m_InternalObject.blendDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["importance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.importance ),
                x => m_InternalObject.importance = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["isBoxProjection"] = new BSReflectionReference(
                () => m_InternalObject.isBoxProjection ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isBoxProjection = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < VisibleReflectionProbe >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_VisibleLight : BSWrapperObject < VisibleLight >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_VisibleLight( VisibleLight obj ) : base( obj )
        {
            m_Properties["light"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Light( m_InternalObject.light ),
                null );

            m_Properties["finalColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.finalColor ),
                x => m_InternalObject.finalColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["screenRect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.screenRect ),
                x => m_InternalObject.screenRect = WrapperHelper.UnwrapObject < Rect >( x ) );

            m_Properties["localToWorldMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.localToWorldMatrix ),
                x => m_InternalObject.localToWorldMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["range"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.range ),
                x => m_InternalObject.range = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["spotAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spotAngle ),
                x => m_InternalObject.spotAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["intersectsNearPlane"] = new BSReflectionReference(
                () => m_InternalObject.intersectsNearPlane ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.intersectsNearPlane = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["intersectsFarPlane"] = new BSReflectionReference(
                () => m_InternalObject.intersectsFarPlane ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.intersectsFarPlane = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < VisibleLight >( a[0] ) )
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

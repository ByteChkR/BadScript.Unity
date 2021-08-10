using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_ShadowSplitData : BSWrapperObject < ShadowSplitData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_ShadowSplitData( ShadowSplitData obj ) : base( obj )
        {
            m_Properties["cullingPlaneCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cullingPlaneCount ),
                x => m_InternalObject.cullingPlaneCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["cullingSphere"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.cullingSphere ),
                x => m_InternalObject.cullingSphere = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["shadowCascadeBlendCullingFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowCascadeBlendCullingFactor ),
                x => m_InternalObject.shadowCascadeBlendCullingFactor = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["GetCullingPlane"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCullingPlane(index)",
                    a => new BSWrapperObject_UnityEngine_Plane(
                        m_InternalObject.GetCullingPlane( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < ShadowSplitData >( a[0] ) )
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

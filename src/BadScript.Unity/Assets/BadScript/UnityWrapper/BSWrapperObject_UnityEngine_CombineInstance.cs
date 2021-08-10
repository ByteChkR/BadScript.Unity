using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CombineInstance : BSWrapperObject < CombineInstance >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CombineInstance( CombineInstance obj ) : base( obj )
        {
            m_Properties["mesh"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Mesh( m_InternalObject.mesh ),
                x => m_InternalObject.mesh = WrapperHelper.UnwrapObject < Mesh >( x ) );

            m_Properties["subMeshIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.subMeshIndex ),
                x => m_InternalObject.subMeshIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.transform ),
                x => m_InternalObject.transform = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["lightmapScaleOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.lightmapScaleOffset ),
                x => m_InternalObject.lightmapScaleOffset = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["realtimeLightmapScaleOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.realtimeLightmapScaleOffset ),
                x => m_InternalObject.realtimeLightmapScaleOffset = WrapperHelper.UnwrapObject < Vector4 >( x ) );

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

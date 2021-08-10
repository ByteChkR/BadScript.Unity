using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_FilteringSettings : BSWrapperObject < FilteringSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_FilteringSettings( FilteringSettings obj ) : base( obj )
        {
            m_Properties["renderQueueRange"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderQueueRange( m_InternalObject.renderQueueRange ),
                x => m_InternalObject.renderQueueRange = WrapperHelper.UnwrapObject < RenderQueueRange >( x ) );

            m_Properties["layerMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layerMask ),
                x => m_InternalObject.layerMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["renderingLayerMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.renderingLayerMask ),
                x => m_InternalObject.renderingLayerMask = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["excludeMotionVectorObjects"] = new BSReflectionReference(
                () => m_InternalObject.excludeMotionVectorObjects ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.excludeMotionVectorObjects = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["sortingLayerRange"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_SortingLayerRange( m_InternalObject.sortingLayerRange ),
                x => m_InternalObject.sortingLayerRange = WrapperHelper.UnwrapObject < SortingLayerRange >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < FilteringSettings >( a[0] ) )
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

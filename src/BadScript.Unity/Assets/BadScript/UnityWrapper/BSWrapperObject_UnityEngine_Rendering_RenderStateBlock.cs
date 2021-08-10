using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_RenderStateBlock : BSWrapperObject < RenderStateBlock >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_RenderStateBlock( RenderStateBlock obj ) : base( obj )
        {
            m_Properties["blendState"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_BlendState( m_InternalObject.blendState ),
                x => m_InternalObject.blendState = WrapperHelper.UnwrapObject < BlendState >( x ) );

            m_Properties["rasterState"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RasterState( m_InternalObject.rasterState ),
                x => m_InternalObject.rasterState = WrapperHelper.UnwrapObject < RasterState >( x ) );

            m_Properties["depthState"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_DepthState( m_InternalObject.depthState ),
                x => m_InternalObject.depthState = WrapperHelper.UnwrapObject < DepthState >( x ) );

            m_Properties["stencilState"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_StencilState( m_InternalObject.stencilState ),
                x => m_InternalObject.stencilState = WrapperHelper.UnwrapObject < StencilState >( x ) );

            m_Properties["stencilReference"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stencilReference ),
                x => m_InternalObject.stencilReference = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < RenderStateBlock >( a[0] ) )
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

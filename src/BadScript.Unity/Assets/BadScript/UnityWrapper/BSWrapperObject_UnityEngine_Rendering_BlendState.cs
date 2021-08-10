using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_BlendState : BSWrapperObject < BlendState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_BlendState( BlendState obj ) : base( obj )
        {
            m_Properties["separateMRTBlendStates"] = new BSReflectionReference(
                () => m_InternalObject.separateMRTBlendStates ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.separateMRTBlendStates = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["alphaToMask"] = new BSReflectionReference(
                () => m_InternalObject.alphaToMask ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.alphaToMask = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["blendState0"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState( m_InternalObject.blendState0 ),
                x => m_InternalObject.blendState0 = WrapperHelper.UnwrapObject < RenderTargetBlendState >( x ) );

            m_Properties["blendState1"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState( m_InternalObject.blendState1 ),
                x => m_InternalObject.blendState1 = WrapperHelper.UnwrapObject < RenderTargetBlendState >( x ) );

            m_Properties["blendState2"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState( m_InternalObject.blendState2 ),
                x => m_InternalObject.blendState2 = WrapperHelper.UnwrapObject < RenderTargetBlendState >( x ) );

            m_Properties["blendState3"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState( m_InternalObject.blendState3 ),
                x => m_InternalObject.blendState3 = WrapperHelper.UnwrapObject < RenderTargetBlendState >( x ) );

            m_Properties["blendState4"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState( m_InternalObject.blendState4 ),
                x => m_InternalObject.blendState4 = WrapperHelper.UnwrapObject < RenderTargetBlendState >( x ) );

            m_Properties["blendState5"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState( m_InternalObject.blendState5 ),
                x => m_InternalObject.blendState5 = WrapperHelper.UnwrapObject < RenderTargetBlendState >( x ) );

            m_Properties["blendState6"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState( m_InternalObject.blendState6 ),
                x => m_InternalObject.blendState6 = WrapperHelper.UnwrapObject < RenderTargetBlendState >( x ) );

            m_Properties["blendState7"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState( m_InternalObject.blendState7 ),
                x => m_InternalObject.blendState7 = WrapperHelper.UnwrapObject < RenderTargetBlendState >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < BlendState >( a[0] ) )
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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_AttachmentDescriptor : BSWrapperObject < AttachmentDescriptor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_AttachmentDescriptor( AttachmentDescriptor obj ) : base( obj )
        {
            m_Properties["loadStoreTarget"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier(
                    m_InternalObject.loadStoreTarget ),
                x => m_InternalObject.loadStoreTarget = WrapperHelper.UnwrapObject < RenderTargetIdentifier >( x ) );

            m_Properties["resolveTarget"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier(
                    m_InternalObject.resolveTarget ),
                x => m_InternalObject.resolveTarget = WrapperHelper.UnwrapObject < RenderTargetIdentifier >( x ) );

            m_Properties["clearColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.clearColor ),
                x => m_InternalObject.clearColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["clearDepth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clearDepth ),
                x => m_InternalObject.clearDepth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["clearStencil"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clearStencil ),
                x => m_InternalObject.clearStencil = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < AttachmentDescriptor >( a[0] ) )
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

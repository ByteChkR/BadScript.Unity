using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_RenderTextureDescriptor : BSWrapperObject < RenderTextureDescriptor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RenderTextureDescriptor( RenderTextureDescriptor obj ) : base( obj )
        {
            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["msaaSamples"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.msaaSamples ),
                x => m_InternalObject.msaaSamples = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["volumeDepth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.volumeDepth ),
                x => m_InternalObject.volumeDepth = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["mipCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mipCount ),
                x => m_InternalObject.mipCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sRGB"] = new BSReflectionReference(
                () => m_InternalObject.sRGB ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.sRGB = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["depthBufferBits"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.depthBufferBits ),
                x => m_InternalObject.depthBufferBits = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["useMipMap"] = new BSReflectionReference(
                () => m_InternalObject.useMipMap ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useMipMap = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["autoGenerateMips"] = new BSReflectionReference(
                () => m_InternalObject.autoGenerateMips ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoGenerateMips = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enableRandomWrite"] = new BSReflectionReference(
                () => m_InternalObject.enableRandomWrite ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableRandomWrite = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["bindMS"] = new BSReflectionReference(
                () => m_InternalObject.bindMS ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bindMS = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useDynamicScale"] = new BSReflectionReference(
                () => m_InternalObject.useDynamicScale ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useDynamicScale = WrapperHelper.UnwrapObject < bool >( x ) );

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

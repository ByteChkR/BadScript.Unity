using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Rendering_RenderTargetBinding : BSWrapperObject < RenderTargetBinding >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_RenderTargetBinding( RenderTargetBinding obj ) : base( obj )
        {
            m_Properties["depthRenderTarget"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier(
                    m_InternalObject.depthRenderTarget ),
                x => m_InternalObject.depthRenderTarget = WrapperHelper.UnwrapObject < RenderTargetIdentifier >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}

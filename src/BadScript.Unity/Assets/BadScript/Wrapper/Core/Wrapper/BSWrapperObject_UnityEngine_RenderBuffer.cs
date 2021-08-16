using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_RenderBuffer : BSWrapperObject < RenderBuffer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RenderBuffer( RenderBuffer obj ) : base( obj )
        {
            m_Properties["GetNativeRenderBufferPtr"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNativeRenderBufferPtr()",
                    a => new BSWrapperObject_System_IntPtr( m_InternalObject.GetNativeRenderBufferPtr() ),
                    0 ) );

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

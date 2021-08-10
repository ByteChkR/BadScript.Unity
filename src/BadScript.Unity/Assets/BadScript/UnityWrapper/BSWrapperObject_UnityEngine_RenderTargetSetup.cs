using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_RenderTargetSetup : BSWrapperObject < RenderTargetSetup >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RenderTargetSetup( RenderTargetSetup obj ) : base( obj )
        {
            m_Properties["depth"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderBuffer( m_InternalObject.depth ),
                x => m_InternalObject.depth = WrapperHelper.UnwrapObject < RenderBuffer >( x ) );

            m_Properties["mipLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mipLevel ),
                x => m_InternalObject.mipLevel = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["depthSlice"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.depthSlice ),
                x => m_InternalObject.depthSlice = WrapperHelper.UnwrapObject < int >( x ) );

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

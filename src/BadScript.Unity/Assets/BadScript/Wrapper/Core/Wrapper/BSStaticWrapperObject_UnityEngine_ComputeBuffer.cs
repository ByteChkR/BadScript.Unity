using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_ComputeBuffer : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ComputeBuffer() : base( typeof( ComputeBuffer ) )
        {
            m_StaticProperties["CopyCount"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyCount(src, dst, dstOffsetBytes)",
                    a =>
                    {
                        ComputeBuffer.CopyCount(
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

        }

        #endregion
    }

}

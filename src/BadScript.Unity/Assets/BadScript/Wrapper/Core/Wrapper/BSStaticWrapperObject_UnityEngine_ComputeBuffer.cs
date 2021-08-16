using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_ComputeBuffer : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_ComputeBuffer() : base(typeof(UnityEngine.ComputeBuffer))
        {
            m_StaticProperties["CopyCount"] = new BSFunctionReference(new BSFunction("function CopyCount(src, dst, dstOffsetBytes)", a => {
                UnityEngine.ComputeBuffer.CopyCount(WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));

        }
    }

}
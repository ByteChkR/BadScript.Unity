using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_GraphicsBuffer : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_GraphicsBuffer() : base(typeof(UnityEngine.GraphicsBuffer))
        {
            m_StaticProperties["CopyCount"] = new BSFunctionReference(new BSFunction("function CopyCount(src, dst, dstOffsetBytes)", a => {
                UnityEngine.GraphicsBuffer.CopyCount(WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["CopyCount"] = new BSFunctionReference(new BSFunction("function CopyCount(src, dst, dstOffsetBytes)", a => {
                UnityEngine.GraphicsBuffer.CopyCount(WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["CopyCount"] = new BSFunctionReference(new BSFunction("function CopyCount(src, dst, dstOffsetBytes)", a => {
                UnityEngine.GraphicsBuffer.CopyCount(WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["CopyCount"] = new BSFunctionReference(new BSFunction("function CopyCount(src, dst, dstOffsetBytes)", a => {
                UnityEngine.GraphicsBuffer.CopyCount(WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));

        }
    }

}
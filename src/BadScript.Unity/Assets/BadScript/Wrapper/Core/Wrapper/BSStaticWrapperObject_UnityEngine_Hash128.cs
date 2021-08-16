using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Hash128 : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Hash128() : base(typeof(UnityEngine.Hash128))
        {
            m_StaticProperties["Parse"] = new BSFunctionReference(new BSFunction("function Parse(hashString)", a => new BSWrapperObject_UnityEngine_Hash128(UnityEngine.Hash128.Parse(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["Compute"] = new BSFunctionReference(new BSFunction("function Compute(data)", a => new BSWrapperObject_UnityEngine_Hash128(UnityEngine.Hash128.Compute(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["Compute"] = new BSFunctionReference(new BSFunction("function Compute(val)", a => new BSWrapperObject_UnityEngine_Hash128(UnityEngine.Hash128.Compute(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["Compute"] = new BSFunctionReference(new BSFunction("function Compute(val)", a => new BSWrapperObject_UnityEngine_Hash128(UnityEngine.Hash128.Compute(WrapperHelper.UnwrapObject<System.Single>(a[0]))), 1));

        }
    }

}
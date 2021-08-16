using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Profiling_CustomSampler : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Profiling_CustomSampler() : base(typeof(UnityEngine.Profiling.CustomSampler))
        {
            m_StaticProperties["Create"] = new BSFunctionReference(new BSFunction("function Create(name, collectGpuData)", a => new BSWrapperObject_UnityEngine_Profiling_CustomSampler(UnityEngine.Profiling.CustomSampler.Create(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]))), 2));

        }
    }

}
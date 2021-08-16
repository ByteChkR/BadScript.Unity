using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Profiling_Recorder : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Profiling_Recorder() : base(typeof(UnityEngine.Profiling.Recorder))
        {
            m_StaticProperties["Get"] = new BSFunctionReference(new BSFunction("function Get(samplerName)", a => new BSWrapperObject_UnityEngine_Profiling_Recorder(UnityEngine.Profiling.Recorder.Get(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
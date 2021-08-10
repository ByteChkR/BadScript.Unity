using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Profiling.Memory.Experimental;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler() : base(
            typeof( MemoryProfiler ) )
        {

        }

        #endregion
    }

}

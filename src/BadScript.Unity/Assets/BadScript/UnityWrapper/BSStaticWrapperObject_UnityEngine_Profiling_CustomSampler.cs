using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Profiling;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Profiling_CustomSampler : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Profiling_CustomSampler() : base( typeof( CustomSampler ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(name, collectGpuData)",
                    a => new BSWrapperObject_UnityEngine_Profiling_CustomSampler(
                        CustomSampler.Create(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

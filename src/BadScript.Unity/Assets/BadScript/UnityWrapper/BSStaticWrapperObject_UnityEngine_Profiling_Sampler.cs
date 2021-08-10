using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Profiling;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Profiling_Sampler : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Profiling_Sampler() : base( typeof( Sampler ) )
        {
            m_StaticProperties["Get"] = new BSFunctionReference(
                new BSFunction(
                    "function Get(name)",
                    a => new BSWrapperObject_UnityEngine_Profiling_Sampler(
                        Sampler.Get( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

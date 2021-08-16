using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Profiling;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Profiling_Recorder : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Profiling_Recorder() : base( typeof( Recorder ) )
        {
            m_StaticProperties["Get"] = new BSFunctionReference(
                new BSFunction(
                    "function Get(samplerName)",
                    a => new BSWrapperObject_UnityEngine_Profiling_Recorder(
                        Recorder.Get( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

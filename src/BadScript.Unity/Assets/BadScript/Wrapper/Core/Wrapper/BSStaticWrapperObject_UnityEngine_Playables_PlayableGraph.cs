using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Playables;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Playables_PlayableGraph : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Playables_PlayableGraph() : base( typeof( PlayableGraph ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create()",
                    a => new BSWrapperObject_UnityEngine_Playables_PlayableGraph( PlayableGraph.Create() ),
                    0 ) );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(name)",
                    a => new BSWrapperObject_UnityEngine_Playables_PlayableGraph(
                        PlayableGraph.Create( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Playables_PlayableGraph : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Playables_PlayableGraph() : base(typeof(UnityEngine.Playables.PlayableGraph))
        {
            m_StaticProperties["Create"] = new BSFunctionReference(new BSFunction("function Create()", a => new BSWrapperObject_UnityEngine_Playables_PlayableGraph(UnityEngine.Playables.PlayableGraph.Create()), 0));
            m_StaticProperties["Create"] = new BSFunctionReference(new BSFunction("function Create(name)", a => new BSWrapperObject_UnityEngine_Playables_PlayableGraph(UnityEngine.Playables.PlayableGraph.Create(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
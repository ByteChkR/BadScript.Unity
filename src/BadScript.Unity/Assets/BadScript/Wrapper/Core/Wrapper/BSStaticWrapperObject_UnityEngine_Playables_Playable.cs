using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Playables_Playable : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Playables_Playable() : base(typeof(UnityEngine.Playables.Playable))
        {
            m_StaticProperties["Null"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Playables_Playable(UnityEngine.Playables.Playable.Null), null);
            m_StaticProperties["Create"] = new BSFunctionReference(new BSFunction("function Create(graph, inputCount)", a => new BSWrapperObject_UnityEngine_Playables_Playable(UnityEngine.Playables.Playable.Create(WrapperHelper.UnwrapObject<UnityEngine.Playables.PlayableGraph>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));

        }
    }

}
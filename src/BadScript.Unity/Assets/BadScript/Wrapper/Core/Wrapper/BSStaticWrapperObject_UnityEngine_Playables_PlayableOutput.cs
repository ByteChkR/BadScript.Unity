using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Playables_PlayableOutput : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Playables_PlayableOutput() : base(typeof(UnityEngine.Playables.PlayableOutput))
        {
            m_StaticProperties["Null"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Playables_PlayableOutput(UnityEngine.Playables.PlayableOutput.Null), null);

        }
    }

}
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Playables_PlayableOutputHandle : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Playables_PlayableOutputHandle() : base(typeof(UnityEngine.Playables.PlayableOutputHandle))
        {
            m_StaticProperties["Null"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Playables_PlayableOutputHandle(UnityEngine.Playables.PlayableOutputHandle.Null), null);

        }
    }

}
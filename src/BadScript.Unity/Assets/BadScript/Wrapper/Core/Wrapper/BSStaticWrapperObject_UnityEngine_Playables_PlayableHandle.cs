using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Playables_PlayableHandle : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Playables_PlayableHandle() : base(typeof(UnityEngine.Playables.PlayableHandle))
        {
            m_StaticProperties["Null"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Playables_PlayableHandle(UnityEngine.Playables.PlayableHandle.Null), null);

        }
    }

}
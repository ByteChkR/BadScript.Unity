using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_IExperimentalFeatures : BSWrapperObject<UnityEngine.UIElements.IExperimentalFeatures>

    {
        public BSWrapperObject_UnityEngine_UIElements_IExperimentalFeatures(UnityEngine.UIElements.IExperimentalFeatures obj) : base(obj)
        {
            m_Properties["animation"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_Experimental_ITransitionAnimations(m_InternalObject.animation), null);

        }
    }

}
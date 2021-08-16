using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class
        BSWrapperObject_UnityEngine_UIElements_IExperimentalFeatures : BSWrapperObject < IExperimentalFeatures >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IExperimentalFeatures( IExperimentalFeatures obj ) : base( obj )
        {
            m_Properties["animation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_Experimental_ITransitionAnimations(
                    m_InternalObject.animation ),
                null );

        }

        #endregion
    }

}

using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Experimental.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSStaticWrapperObject_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystemSettings :
            BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystemSettings() :
            base( typeof( ScriptableRuntimeReflectionSystemSettings ) )
        {
            m_StaticProperties["system"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Experimental_Rendering_IScriptableRuntimeReflectionSystem(
                    ScriptableRuntimeReflectionSystemSettings.system ),
                x => ScriptableRuntimeReflectionSystemSettings.system =
                    WrapperHelper.UnwrapObject < IScriptableRuntimeReflectionSystem >( x ) );

        }

        #endregion
    }

}

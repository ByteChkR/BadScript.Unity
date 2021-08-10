using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_ScriptableCullingParameters : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_ScriptableCullingParameters() : base(
            typeof( ScriptableCullingParameters ) )
        {
            m_StaticProperties["cullingJobsLowerLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ScriptableCullingParameters.cullingJobsLowerLimit ),
                null );

            m_StaticProperties["cullingJobsUpperLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ScriptableCullingParameters.cullingJobsUpperLimit ),
                null );

            m_StaticProperties["maximumCullingPlaneCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ScriptableCullingParameters.maximumCullingPlaneCount ),
                null );

            m_StaticProperties["layerCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ScriptableCullingParameters.layerCount ),
                null );

        }

        #endregion
    }

}

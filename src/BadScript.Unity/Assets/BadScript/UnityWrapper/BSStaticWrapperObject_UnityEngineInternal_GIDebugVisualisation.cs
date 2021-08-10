using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngineInternal;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngineInternal_GIDebugVisualisation : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngineInternal_GIDebugVisualisation() : base( typeof( GIDebugVisualisation ) )
        {
            m_StaticProperties["cycleMode"] = new BSReflectionReference(
                () => GIDebugVisualisation.cycleMode ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["pauseCycleMode"] = new BSReflectionReference(
                () => GIDebugVisualisation.pauseCycleMode ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

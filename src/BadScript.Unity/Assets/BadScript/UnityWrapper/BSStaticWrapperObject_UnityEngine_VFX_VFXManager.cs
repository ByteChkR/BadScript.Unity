using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.VFX;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_VFX_VFXManager : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_VFX_VFXManager() : base( typeof( VFXManager ) )
        {
            m_StaticProperties["fixedTimeStep"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) VFXManager.fixedTimeStep ),
                x => VFXManager.fixedTimeStep = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["maxDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) VFXManager.maxDeltaTime ),
                x => VFXManager.maxDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

        }

        #endregion
    }

}

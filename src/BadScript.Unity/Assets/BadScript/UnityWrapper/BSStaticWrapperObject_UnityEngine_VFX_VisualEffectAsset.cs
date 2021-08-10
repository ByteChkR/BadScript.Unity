using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.VFX;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_VFX_VisualEffectAsset : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_VFX_VisualEffectAsset() : base( typeof( VisualEffectAsset ) )
        {
            m_StaticProperties["PlayEventName"] = new BSReflectionReference(
                () => new BSObject( VisualEffectAsset.PlayEventName ),
                null );

            m_StaticProperties["StopEventName"] = new BSReflectionReference(
                () => new BSObject( VisualEffectAsset.StopEventName ),
                null );

            m_StaticProperties["PlayEventID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) VisualEffectAsset.PlayEventID ),
                null );

            m_StaticProperties["StopEventID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) VisualEffectAsset.StopEventID ),
                null );

        }

        #endregion
    }

}

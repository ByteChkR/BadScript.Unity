using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering.VirtualTexturing;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_Debugging : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_Debugging() : base( typeof( Debugging ) )
        {
            m_StaticProperties["debugTilesEnabled"] = new BSReflectionReference(
                () => Debugging.debugTilesEnabled ? BSObject.One : BSObject.Zero,
                x => Debugging.debugTilesEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["resolvingEnabled"] = new BSReflectionReference(
                () => Debugging.resolvingEnabled ? BSObject.One : BSObject.Zero,
                x => Debugging.resolvingEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["flushEveryTickEnabled"] = new BSReflectionReference(
                () => Debugging.flushEveryTickEnabled ? BSObject.One : BSObject.Zero,
                x => Debugging.flushEveryTickEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}

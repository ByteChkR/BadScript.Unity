using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.tvOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_tvOS_Remote : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_tvOS_Remote() : base( typeof( Remote ) )
        {
            m_StaticProperties["allowExitToHome"] = new BSReflectionReference(
                () => Remote.allowExitToHome ? BSObject.One : BSObject.Zero,
                x => Remote.allowExitToHome = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["allowRemoteRotation"] = new BSReflectionReference(
                () => Remote.allowRemoteRotation ? BSObject.One : BSObject.Zero,
                x => Remote.allowRemoteRotation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["reportAbsoluteDpadValues"] = new BSReflectionReference(
                () => Remote.reportAbsoluteDpadValues ? BSObject.One : BSObject.Zero,
                x => Remote.reportAbsoluteDpadValues = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["touchesEnabled"] = new BSReflectionReference(
                () => Remote.touchesEnabled ? BSObject.One : BSObject.Zero,
                x => Remote.touchesEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}

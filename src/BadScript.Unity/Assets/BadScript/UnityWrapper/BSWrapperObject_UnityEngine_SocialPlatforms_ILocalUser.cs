using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_ILocalUser : BSWrapperObject < ILocalUser >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_ILocalUser( ILocalUser obj ) : base( obj )
        {
            m_Properties["authenticated"] = new BSReflectionReference(
                () => m_InternalObject.authenticated ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["underage"] = new BSReflectionReference(
                () => m_InternalObject.underage ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

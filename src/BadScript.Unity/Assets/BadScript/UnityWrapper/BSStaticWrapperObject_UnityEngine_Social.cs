using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Social : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Social() : base( typeof( Social ) )
        {
            m_StaticProperties["Active"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SocialPlatforms_ISocialPlatform( Social.Active ),
                x => Social.Active = WrapperHelper.UnwrapObject < ISocialPlatform >( x ) );

            m_StaticProperties["localUser"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SocialPlatforms_ILocalUser( Social.localUser ),
                null );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_ISocialPlatform : BSWrapperObject < ISocialPlatform >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_ISocialPlatform( ISocialPlatform obj ) : base( obj )
        {
            m_Properties["localUser"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SocialPlatforms_ILocalUser( m_InternalObject.localUser ),
                null );

            m_Properties["GetLoading"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLoading(board)",
                    a => m_InternalObject.GetLoading( WrapperHelper.UnwrapObject < ILeaderboard >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

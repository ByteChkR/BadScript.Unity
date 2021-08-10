using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_IUserProfile : BSWrapperObject < IUserProfile >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_IUserProfile( IUserProfile obj ) : base( obj )
        {
            m_Properties["userName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.userName ),
                null );

            m_Properties["id"] = new BSReflectionReference( () => new BSObject( m_InternalObject.id ), null );

            m_Properties["isFriend"] = new BSReflectionReference(
                () => m_InternalObject.isFriend ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["image"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.image ),
                null );

        }

        #endregion
    }

}

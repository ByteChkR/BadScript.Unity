using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms.Impl;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_Impl_UserProfile : BSWrapperObject < UserProfile >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_Impl_UserProfile( UserProfile obj ) : base( obj )
        {
            m_Properties["userName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.userName ),
                null );

            m_Properties["id"] = new BSReflectionReference( () => new BSObject( m_InternalObject.id ), null );
            m_Properties["legacyId"] = new BSReflectionReference( () => new BSObject( m_InternalObject.id ), null );
            m_Properties["gameId"] = new BSReflectionReference( () => new BSObject( m_InternalObject.gameId ), null );

            m_Properties["isFriend"] = new BSReflectionReference(
                () => m_InternalObject.isFriend ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["image"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.image ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

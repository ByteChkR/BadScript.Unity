using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_Impl_Leaderboard : BSWrapperObject < Leaderboard >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_Impl_Leaderboard( Leaderboard obj ) : base( obj )
        {
            m_Properties["loading"] = new BSReflectionReference(
                () => m_InternalObject.loading ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["id"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.id ),
                x => m_InternalObject.id = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["range"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SocialPlatforms_Range( m_InternalObject.range ),
                x => m_InternalObject.range = WrapperHelper.UnwrapObject < Range >( x ) );

            m_Properties["localUserScore"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SocialPlatforms_IScore( m_InternalObject.localUserScore ),
                null );

            m_Properties["maxRange"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxRange ),
                null );

            m_Properties["title"] = new BSReflectionReference( () => new BSObject( m_InternalObject.title ), null );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms.Impl;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_SocialPlatforms_Impl_AchievementDescription : BSWrapperObject <
            AchievementDescription >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_Impl_AchievementDescription( AchievementDescription obj ) :
            base( obj )
        {
            m_Properties["id"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.id ),
                x => m_InternalObject.id = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["title"] = new BSReflectionReference( () => new BSObject( m_InternalObject.title ), null );

            m_Properties["image"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.image ),
                null );

            m_Properties["achievedDescription"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.achievedDescription ),
                null );

            m_Properties["unachievedDescription"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.unachievedDescription ),
                null );

            m_Properties["hidden"] = new BSReflectionReference(
                () => m_InternalObject.hidden ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["points"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.points ),
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

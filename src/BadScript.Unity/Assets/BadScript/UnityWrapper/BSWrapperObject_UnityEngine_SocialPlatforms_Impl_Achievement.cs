using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms.Impl;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_Impl_Achievement : BSWrapperObject < Achievement >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_Impl_Achievement( Achievement obj ) : base( obj )
        {
            m_Properties["id"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.id ),
                x => m_InternalObject.id = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["percentCompleted"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.percentCompleted ),
                x => m_InternalObject.percentCompleted = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["completed"] = new BSReflectionReference(
                () => m_InternalObject.completed ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hidden"] = new BSReflectionReference(
                () => m_InternalObject.hidden ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["lastReportedDate"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( m_InternalObject.lastReportedDate ),
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

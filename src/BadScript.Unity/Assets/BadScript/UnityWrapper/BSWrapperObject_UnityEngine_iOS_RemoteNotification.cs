using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.iOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_iOS_RemoteNotification : BSWrapperObject < RemoteNotification >

    {
        #region Public

        public BSWrapperObject_UnityEngine_iOS_RemoteNotification( RemoteNotification obj ) : base( obj )
        {
            m_Properties["alertBody"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.alertBody ),
                null );

            m_Properties["alertTitle"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.alertTitle ),
                null );

            m_Properties["soundName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.soundName ),
                null );

            m_Properties["applicationIconBadgeNumber"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.applicationIconBadgeNumber ),
                null );

            m_Properties["userInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Collections_IDictionary( m_InternalObject.userInfo ),
                null );

            m_Properties["hasAction"] = new BSReflectionReference(
                () => m_InternalObject.hasAction ? BSObject.One : BSObject.Zero,
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

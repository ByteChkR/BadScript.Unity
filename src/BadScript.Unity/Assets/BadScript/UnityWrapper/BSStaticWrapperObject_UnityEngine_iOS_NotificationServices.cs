using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.iOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_iOS_NotificationServices : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_iOS_NotificationServices() : base( typeof( NotificationServices ) )
        {
            m_StaticProperties["localNotificationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) NotificationServices.localNotificationCount ),
                null );

            m_StaticProperties["remoteNotificationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) NotificationServices.remoteNotificationCount ),
                null );

            m_StaticProperties["registrationError"] = new BSReflectionReference(
                () => new BSObject( NotificationServices.registrationError ),
                null );

            m_StaticProperties["GetLocalNotification"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLocalNotification(index)",
                    a => new BSWrapperObject_UnityEngine_iOS_LocalNotification(
                        NotificationServices.GetLocalNotification( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetRemoteNotification"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRemoteNotification(index)",
                    a => new BSWrapperObject_UnityEngine_iOS_RemoteNotification(
                        NotificationServices.GetRemoteNotification( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using System;
using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.iOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_iOS_LocalNotification : BSWrapperObject < LocalNotification >

    {
        #region Public

        public BSWrapperObject_UnityEngine_iOS_LocalNotification( LocalNotification obj ) : base( obj )
        {
            m_Properties["timeZone"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.timeZone ),
                x => m_InternalObject.timeZone = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["fireDate"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( m_InternalObject.fireDate ),
                x => m_InternalObject.fireDate = WrapperHelper.UnwrapObject < DateTime >( x ) );

            m_Properties["alertBody"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.alertBody ),
                x => m_InternalObject.alertBody = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["alertTitle"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.alertTitle ),
                x => m_InternalObject.alertTitle = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["alertAction"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.alertAction ),
                x => m_InternalObject.alertAction = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["alertLaunchImage"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.alertLaunchImage ),
                x => m_InternalObject.alertLaunchImage = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["soundName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.soundName ),
                x => m_InternalObject.soundName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["applicationIconBadgeNumber"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.applicationIconBadgeNumber ),
                x => m_InternalObject.applicationIconBadgeNumber = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["userInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Collections_IDictionary( m_InternalObject.userInfo ),
                x => m_InternalObject.userInfo = WrapperHelper.UnwrapObject < IDictionary >( x ) );

            m_Properties["hasAction"] = new BSReflectionReference(
                () => m_InternalObject.hasAction ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.hasAction = WrapperHelper.UnwrapObject < bool >( x ) );

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

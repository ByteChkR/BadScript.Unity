using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_RemoteSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_RemoteSettings() : base( typeof( RemoteSettings ) )
        {
            m_StaticProperties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(key)",
                    a => new BSObject(
                        ( decimal ) RemoteSettings.GetInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(key, defaultValue)",
                    a => new BSObject(
                        ( decimal ) RemoteSettings.GetInt(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetLong"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLong(key)",
                    a => new BSObject(
                        ( decimal ) RemoteSettings.GetLong( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetLong"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLong(key, defaultValue)",
                    a => new BSObject(
                        ( decimal ) RemoteSettings.GetLong(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < long >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(key)",
                    a => new BSObject(
                        ( decimal ) RemoteSettings.GetFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(key, defaultValue)",
                    a => new BSObject(
                        ( decimal ) RemoteSettings.GetFloat(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetString(key)",
                    a => new BSObject( RemoteSettings.GetString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetString(key, defaultValue)",
                    a => new BSObject(
                        RemoteSettings.GetString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(key)",
                    a => RemoteSettings.GetBool( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(key, defaultValue)",
                    a => RemoteSettings.GetBool(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["HasKey"] = new BSFunctionReference(
                new BSFunction(
                    "function HasKey(key)",
                    a => RemoteSettings.HasKey( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetObject"] = new BSFunctionReference(
                new BSFunction(
                    "function GetObject(key, defaultValue)",
                    a => new BSWrapperObject_System_Object(
                        RemoteSettings.GetObject(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

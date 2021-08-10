using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_RemoteConfigSettings : BSWrapperObject < RemoteConfigSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RemoteConfigSettings( RemoteConfigSettings obj ) : base( obj )
        {
            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(key)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(key, defaultValue)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetLong"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLong(key)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLong( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetLong"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLong(key, defaultValue)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLong(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < long >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(key)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(key, defaultValue)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetString(key)",
                    a => new BSObject( m_InternalObject.GetString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetString(key, defaultValue)",
                    a => new BSObject(
                        m_InternalObject.GetString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(key)",
                    a => m_InternalObject.GetBool( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(key, defaultValue)",
                    a => m_InternalObject.GetBool(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["HasKey"] = new BSFunctionReference(
                new BSFunction(
                    "function HasKey(key)",
                    a => m_InternalObject.HasKey( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetObject"] = new BSFunctionReference(
                new BSFunction(
                    "function GetObject(key, defaultValue)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.GetObject(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

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

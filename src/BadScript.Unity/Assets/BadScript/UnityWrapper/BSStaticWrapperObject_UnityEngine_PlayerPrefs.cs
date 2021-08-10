using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_PlayerPrefs : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_PlayerPrefs() : base( typeof( PlayerPrefs ) )
        {
            m_StaticProperties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(key, defaultValue)",
                    a => new BSObject(
                        ( decimal ) PlayerPrefs.GetInt(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(key)",
                    a => new BSObject(
                        ( decimal ) PlayerPrefs.GetInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(key, defaultValue)",
                    a => new BSObject(
                        ( decimal ) PlayerPrefs.GetFloat(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(key)",
                    a => new BSObject(
                        ( decimal ) PlayerPrefs.GetFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetString(key, defaultValue)",
                    a => new BSObject(
                        PlayerPrefs.GetString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetString(key)",
                    a => new BSObject( PlayerPrefs.GetString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["HasKey"] = new BSFunctionReference(
                new BSFunction(
                    "function HasKey(key)",
                    a => PlayerPrefs.HasKey( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

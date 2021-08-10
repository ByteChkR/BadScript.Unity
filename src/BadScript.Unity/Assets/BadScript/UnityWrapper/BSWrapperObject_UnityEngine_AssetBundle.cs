using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AssetBundle : BSWrapperObject < AssetBundle >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AssetBundle( AssetBundle obj ) : base( obj )
        {
            m_Properties["mainAsset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Object( m_InternalObject.mainAsset ),
                null );

            m_Properties["isStreamedSceneAssetBundle"] = new BSReflectionReference(
                () => m_InternalObject.isStreamedSceneAssetBundle ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(name)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["LoadAsset"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAsset(name)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        m_InternalObject.LoadAsset( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["LoadAssetAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAssetAsync(name)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleRequest(
                        m_InternalObject.LoadAssetAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["LoadAssetAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAssetAsync(name)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleRequest(
                        m_InternalObject.LoadAssetAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["LoadAssetWithSubAssetsAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAssetWithSubAssetsAsync(name)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleRequest(
                        m_InternalObject.LoadAssetWithSubAssetsAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["LoadAssetWithSubAssetsAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAssetWithSubAssetsAsync(name)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleRequest(
                        m_InternalObject.LoadAssetWithSubAssetsAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

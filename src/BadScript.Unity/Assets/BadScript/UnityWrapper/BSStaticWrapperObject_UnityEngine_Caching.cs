using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Caching : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Caching() : base( typeof( Caching ) )
        {
            m_StaticProperties["compressionEnabled"] = new BSReflectionReference(
                () => Caching.compressionEnabled ? BSObject.One : BSObject.Zero,
                x => Caching.compressionEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["ready"] = new BSReflectionReference(
                () => Caching.ready ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["spaceUsed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Caching.spaceUsed ),
                null );

            m_StaticProperties["spaceOccupied"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Caching.spaceOccupied ),
                null );

            m_StaticProperties["spaceAvailable"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Caching.spaceAvailable ),
                null );

            m_StaticProperties["spaceFree"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Caching.spaceFree ),
                null );

            m_StaticProperties["maximumAvailableDiskSpace"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Caching.maximumAvailableDiskSpace ),
                x => Caching.maximumAvailableDiskSpace = WrapperHelper.UnwrapObject < long >( x ) );

            m_StaticProperties["expirationDelay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Caching.expirationDelay ),
                x => Caching.expirationDelay = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["cacheCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Caching.cacheCount ),
                null );

            m_StaticProperties["defaultCache"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Cache( Caching.defaultCache ),
                null );

            m_StaticProperties["currentCacheForWriting"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Cache( Caching.currentCacheForWriting ),
                x => Caching.currentCacheForWriting = WrapperHelper.UnwrapObject < Cache >( x ) );

            m_StaticProperties["ClearCache"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearCache(expiration)",
                    a => Caching.ClearCache( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["ClearCachedVersion"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearCachedVersion(assetBundleName, hash)",
                    a => Caching.ClearCachedVersion(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < Hash128 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["ClearOtherCachedVersions"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearOtherCachedVersions(assetBundleName, hash)",
                    a => Caching.ClearOtherCachedVersions(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < Hash128 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["ClearAllCachedVersions"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearAllCachedVersions(assetBundleName)",
                    a => Caching.ClearAllCachedVersions( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsVersionCached"] = new BSFunctionReference(
                new BSFunction(
                    "function IsVersionCached(url, version)",
                    a => Caching.IsVersionCached(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsVersionCached"] = new BSFunctionReference(
                new BSFunction(
                    "function IsVersionCached(url, hash)",
                    a => Caching.IsVersionCached(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < Hash128 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsVersionCached"] = new BSFunctionReference(
                new BSFunction(
                    "function IsVersionCached(cachedBundle)",
                    a => Caching.IsVersionCached( WrapperHelper.UnwrapObject < CachedAssetBundle >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["MarkAsUsed"] = new BSFunctionReference(
                new BSFunction(
                    "function MarkAsUsed(url, version)",
                    a => Caching.MarkAsUsed(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["MarkAsUsed"] = new BSFunctionReference(
                new BSFunction(
                    "function MarkAsUsed(url, hash)",
                    a => Caching.MarkAsUsed(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < Hash128 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["MarkAsUsed"] = new BSFunctionReference(
                new BSFunction(
                    "function MarkAsUsed(cachedBundle)",
                    a => Caching.MarkAsUsed( WrapperHelper.UnwrapObject < CachedAssetBundle >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetVersionFromCache"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVersionFromCache(url)",
                    a => new BSObject(
                        ( decimal ) Caching.GetVersionFromCache( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["AddCache"] = new BSFunctionReference(
                new BSFunction(
                    "function AddCache(cachePath)",
                    a => new BSWrapperObject_UnityEngine_Cache(
                        Caching.AddCache( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetCacheAt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCacheAt(cacheIndex)",
                    a => new BSWrapperObject_UnityEngine_Cache(
                        Caching.GetCacheAt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetCacheByPath"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCacheByPath(cachePath)",
                    a => new BSWrapperObject_UnityEngine_Cache(
                        Caching.GetCacheByPath( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["RemoveCache"] = new BSFunctionReference(
                new BSFunction(
                    "function RemoveCache(cache)",
                    a => Caching.RemoveCache( WrapperHelper.UnwrapObject < Cache >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

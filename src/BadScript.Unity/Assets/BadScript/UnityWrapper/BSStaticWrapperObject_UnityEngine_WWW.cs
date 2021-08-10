using System.Text;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_WWW : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_WWW() : base( typeof( WWW ) )
        {
            m_StaticProperties["EscapeURL"] = new BSFunctionReference(
                new BSFunction(
                    "function EscapeURL(s)",
                    a => new BSObject( WWW.EscapeURL( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["EscapeURL"] = new BSFunctionReference(
                new BSFunction(
                    "function EscapeURL(s, e)",
                    a => new BSObject(
                        WWW.EscapeURL(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Encoding >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["UnEscapeURL"] = new BSFunctionReference(
                new BSFunction(
                    "function UnEscapeURL(s)",
                    a => new BSObject( WWW.UnEscapeURL( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["UnEscapeURL"] = new BSFunctionReference(
                new BSFunction(
                    "function UnEscapeURL(s, e)",
                    a => new BSObject(
                        WWW.UnEscapeURL(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Encoding >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadFromCacheOrDownload"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromCacheOrDownload(url, version)",
                    a => new BSWrapperObject_UnityEngine_WWW(
                        WWW.LoadFromCacheOrDownload(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadFromCacheOrDownload"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromCacheOrDownload(url, version, crc)",
                    a => new BSWrapperObject_UnityEngine_WWW(
                        WWW.LoadFromCacheOrDownload(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LoadFromCacheOrDownload"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromCacheOrDownload(url, hash)",
                    a => new BSWrapperObject_UnityEngine_WWW(
                        WWW.LoadFromCacheOrDownload(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Hash128 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadFromCacheOrDownload"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromCacheOrDownload(url, hash, crc)",
                    a => new BSWrapperObject_UnityEngine_WWW(
                        WWW.LoadFromCacheOrDownload(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Hash128 >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LoadFromCacheOrDownload"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromCacheOrDownload(url, cachedBundle, crc)",
                    a => new BSWrapperObject_UnityEngine_WWW(
                        WWW.LoadFromCacheOrDownload(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < CachedAssetBundle >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}

using System.IO;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AssetBundle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AssetBundle() : base( typeof( AssetBundle ) )
        {
            m_StaticProperties["LoadFromFileAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromFileAsync(path)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleCreateRequest(
                        AssetBundle.LoadFromFileAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadFromFileAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromFileAsync(path, crc)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleCreateRequest(
                        AssetBundle.LoadFromFileAsync(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadFromFileAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromFileAsync(path, crc, offset)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleCreateRequest(
                        AssetBundle.LoadFromFileAsync(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < ulong >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LoadFromFile"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromFile(path)",
                    a => new BSWrapperObject_UnityEngine_AssetBundle(
                        AssetBundle.LoadFromFile( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadFromFile"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromFile(path, crc)",
                    a => new BSWrapperObject_UnityEngine_AssetBundle(
                        AssetBundle.LoadFromFile(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadFromFile"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromFile(path, crc, offset)",
                    a => new BSWrapperObject_UnityEngine_AssetBundle(
                        AssetBundle.LoadFromFile(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < ulong >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LoadFromStreamAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromStreamAsync(stream, crc, managedReadBufferSize)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleCreateRequest(
                        AssetBundle.LoadFromStreamAsync(
                            WrapperHelper.UnwrapObject < Stream >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LoadFromStreamAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromStreamAsync(stream, crc)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleCreateRequest(
                        AssetBundle.LoadFromStreamAsync(
                            WrapperHelper.UnwrapObject < Stream >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadFromStreamAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromStreamAsync(stream)",
                    a => new BSWrapperObject_UnityEngine_AssetBundleCreateRequest(
                        AssetBundle.LoadFromStreamAsync( WrapperHelper.UnwrapObject < Stream >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadFromStream"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromStream(stream, crc, managedReadBufferSize)",
                    a => new BSWrapperObject_UnityEngine_AssetBundle(
                        AssetBundle.LoadFromStream(
                            WrapperHelper.UnwrapObject < Stream >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LoadFromStream"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromStream(stream, crc)",
                    a => new BSWrapperObject_UnityEngine_AssetBundle(
                        AssetBundle.LoadFromStream(
                            WrapperHelper.UnwrapObject < Stream >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadFromStream"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFromStream(stream)",
                    a => new BSWrapperObject_UnityEngine_AssetBundle(
                        AssetBundle.LoadFromStream( WrapperHelper.UnwrapObject < Stream >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

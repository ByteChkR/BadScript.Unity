using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Resources : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Resources() : base( typeof( Resources ) )
        {
            m_StaticProperties["Load"] = new BSFunctionReference(
                new BSFunction(
                    "function Load(path)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Resources.Load( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAsync(path)",
                    a => new BSWrapperObject_UnityEngine_ResourceRequest(
                        Resources.LoadAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAsync(path)",
                    a => new BSWrapperObject_UnityEngine_ResourceRequest(
                        Resources.LoadAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["UnloadAsset"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadAsset(assetToUnload)",
                    a =>
                    {
                        Resources.UnloadAsset( WrapperHelper.UnwrapObject < Object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["UnloadUnusedAssets"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadUnusedAssets()",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation( Resources.UnloadUnusedAssets() ),
                    0 ) );

            m_StaticProperties["InstanceIDToObject"] = new BSFunctionReference(
                new BSFunction(
                    "function InstanceIDToObject(instanceID)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Resources.InstanceIDToObject( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

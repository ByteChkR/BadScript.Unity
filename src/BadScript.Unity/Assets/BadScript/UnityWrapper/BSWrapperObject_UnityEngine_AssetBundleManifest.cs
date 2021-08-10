using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AssetBundleManifest : BSWrapperObject < AssetBundleManifest >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AssetBundleManifest( AssetBundleManifest obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetAssetBundleHash"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundleHash(assetBundleName)",
                    a => new BSWrapperObject_UnityEngine_Hash128(
                        m_InternalObject.GetAssetBundleHash( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
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

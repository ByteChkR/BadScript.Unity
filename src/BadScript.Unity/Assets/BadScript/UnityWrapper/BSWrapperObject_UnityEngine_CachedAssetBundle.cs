using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CachedAssetBundle : BSWrapperObject < CachedAssetBundle >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CachedAssetBundle( CachedAssetBundle obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["hash"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Hash128( m_InternalObject.hash ),
                x => m_InternalObject.hash = WrapperHelper.UnwrapObject < Hash128 >( x ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CacheIndex : BSWrapperObject < CacheIndex >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CacheIndex( CacheIndex obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["bytesUsed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bytesUsed ),
                x => m_InternalObject.bytesUsed = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["expires"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.expires ),
                x => m_InternalObject.expires = WrapperHelper.UnwrapObject < int >( x ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ShaderVariantCollection : BSWrapperObject < ShaderVariantCollection >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ShaderVariantCollection( ShaderVariantCollection obj ) : base( obj )
        {
            m_Properties["shaderCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shaderCount ),
                null );

            m_Properties["variantCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.variantCount ),
                null );

            m_Properties["isWarmedUp"] = new BSReflectionReference(
                () => m_InternalObject.isWarmedUp ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

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

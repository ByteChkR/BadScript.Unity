using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ComputeShader : BSWrapperObject < ComputeShader >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ComputeShader( ComputeShader obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["FindKernel"] = new BSFunctionReference(
                new BSFunction(
                    "function FindKernel(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.FindKernel( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["HasKernel"] = new BSFunctionReference(
                new BSFunction(
                    "function HasKernel(name)",
                    a => m_InternalObject.HasKernel( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsKeywordEnabled"] = new BSFunctionReference(
                new BSFunction(
                    "function IsKeywordEnabled(keyword)",
                    a => m_InternalObject.IsKeywordEnabled( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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

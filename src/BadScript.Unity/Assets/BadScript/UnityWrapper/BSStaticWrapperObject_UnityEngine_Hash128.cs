using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Hash128 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Hash128() : base( typeof( Hash128 ) )
        {
            m_StaticProperties["Parse"] = new BSFunctionReference(
                new BSFunction(
                    "function Parse(hashString)",
                    a => new BSWrapperObject_UnityEngine_Hash128(
                        Hash128.Parse( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Compute"] = new BSFunctionReference(
                new BSFunction(
                    "function Compute(data)",
                    a => new BSWrapperObject_UnityEngine_Hash128(
                        Hash128.Compute( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Compute"] = new BSFunctionReference(
                new BSFunction(
                    "function Compute(val)",
                    a => new BSWrapperObject_UnityEngine_Hash128(
                        Hash128.Compute( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Compute"] = new BSFunctionReference(
                new BSFunction(
                    "function Compute(val)",
                    a => new BSWrapperObject_UnityEngine_Hash128(
                        Hash128.Compute( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

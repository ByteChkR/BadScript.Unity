using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Animator : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Animator() : base( typeof( Animator ) )
        {
            m_StaticProperties["StringToHash"] = new BSFunctionReference(
                new BSFunction(
                    "function StringToHash(name)",
                    a => new BSObject(
                        ( decimal ) Animator.StringToHash( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

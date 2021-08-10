using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_WSA_Toast : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_WSA_Toast() : base( typeof( Toast ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(xml)",
                    a => new BSWrapperObject_UnityEngine_WSA_Toast(
                        Toast.Create( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(image, text)",
                    a => new BSWrapperObject_UnityEngine_WSA_Toast(
                        Toast.Create(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

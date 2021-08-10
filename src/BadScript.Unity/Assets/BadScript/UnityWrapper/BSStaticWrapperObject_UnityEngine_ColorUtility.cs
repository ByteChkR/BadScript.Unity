using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ColorUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ColorUtility() : base( typeof( ColorUtility ) )
        {
            m_StaticProperties["ToHtmlStringRGB"] = new BSFunctionReference(
                new BSFunction(
                    "function ToHtmlStringRGB(color)",
                    a => new BSObject( ColorUtility.ToHtmlStringRGB( WrapperHelper.UnwrapObject < Color >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ToHtmlStringRGBA"] = new BSFunctionReference(
                new BSFunction(
                    "function ToHtmlStringRGBA(color)",
                    a => new BSObject( ColorUtility.ToHtmlStringRGBA( WrapperHelper.UnwrapObject < Color >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

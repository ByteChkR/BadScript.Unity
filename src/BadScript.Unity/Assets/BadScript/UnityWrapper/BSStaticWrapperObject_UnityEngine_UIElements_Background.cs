using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Background : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Background() : base( typeof( Background ) )
        {
            m_StaticProperties["FromTexture2D"] = new BSFunctionReference(
                new BSFunction(
                    "function FromTexture2D(t)",
                    a => new BSWrapperObject_UnityEngine_UIElements_Background(
                        Background.FromTexture2D( WrapperHelper.UnwrapObject < Texture2D >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromVectorImage"] = new BSFunctionReference(
                new BSFunction(
                    "function FromVectorImage(vi)",
                    a => new BSWrapperObject_UnityEngine_UIElements_Background(
                        Background.FromVectorImage( WrapperHelper.UnwrapObject < VectorImage >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

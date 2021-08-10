using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Sprite : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Sprite() : base( typeof( Sprite ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(texture, rect, pivot, pixelsPerUnit, extrude)",
                    a => new BSWrapperObject_UnityEngine_Sprite(
                        Sprite.Create(
                            WrapperHelper.UnwrapObject < Texture2D >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < uint >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(texture, rect, pivot, pixelsPerUnit)",
                    a => new BSWrapperObject_UnityEngine_Sprite(
                        Sprite.Create(
                            WrapperHelper.UnwrapObject < Texture2D >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(texture, rect, pivot)",
                    a => new BSWrapperObject_UnityEngine_Sprite(
                        Sprite.Create(
                            WrapperHelper.UnwrapObject < Texture2D >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}

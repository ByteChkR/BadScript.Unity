using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.U2D;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_U2D_SpriteDataAccessExtensions : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_U2D_SpriteDataAccessExtensions() : base(
            typeof( SpriteDataAccessExtensions ) )
        {
            m_StaticProperties["GetVertexCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVertexCount(sprite)",
                    a => new BSObject(
                        ( decimal ) SpriteDataAccessExtensions.GetVertexCount(
                            WrapperHelper.UnwrapObject < Sprite >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

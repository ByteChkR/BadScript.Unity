using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext() : base( typeof( PaintContext ) )
        {
            m_StaticProperties["kNormalizedHeightScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PaintContext.kNormalizedHeightScale ),
                null );

            m_StaticProperties["CreateFromBounds"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateFromBounds(terrain, boundsInTerrainSpace, inputTextureWidth, inputTextureHeight, extraBorderPixels, texelPadding)",
                    a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext(
                        PaintContext.CreateFromBounds(
                            WrapperHelper.UnwrapObject < Terrain >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < bool >( a[5] ) ) ),
                    6 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_TerrainPaintUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_TerrainPaintUtility() : base(
            typeof( TerrainPaintUtility ) )
        {
            m_StaticProperties["CalculateBrushTransform"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculateBrushTransform(terrain, brushCenterTerrainUV, brushSize, brushRotationDegrees)",
                    a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_BrushTransform(
                        TerrainPaintUtility.CalculateBrushTransform(
                            WrapperHelper.UnwrapObject < Terrain >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["BeginPaintHeightmap"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginPaintHeightmap(terrain, boundsInTerrainSpace, extraBorderPixels)",
                    a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext(
                        TerrainPaintUtility.BeginPaintHeightmap(
                            WrapperHelper.UnwrapObject < Terrain >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["BeginPaintHoles"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginPaintHoles(terrain, boundsInTerrainSpace, extraBorderPixels)",
                    a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext(
                        TerrainPaintUtility.BeginPaintHoles(
                            WrapperHelper.UnwrapObject < Terrain >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["CollectNormals"] = new BSFunctionReference(
                new BSFunction(
                    "function CollectNormals(terrain, boundsInTerrainSpace, extraBorderPixels)",
                    a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext(
                        TerrainPaintUtility.CollectNormals(
                            WrapperHelper.UnwrapObject < Terrain >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["BeginPaintTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginPaintTexture(terrain, boundsInTerrainSpace, inputLayer, extraBorderPixels)",
                    a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext(
                        TerrainPaintUtility.BeginPaintTexture(
                            WrapperHelper.UnwrapObject < Terrain >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ),
                            WrapperHelper.UnwrapObject < TerrainLayer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["GetTerrainAlphaMapChecked"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTerrainAlphaMapChecked(terrain, mapIndex)",
                    a => new BSWrapperObject_UnityEngine_Texture2D(
                        TerrainPaintUtility.GetTerrainAlphaMapChecked(
                            WrapperHelper.UnwrapObject < Terrain >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["FindTerrainLayerIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function FindTerrainLayerIndex(terrain, inputLayer)",
                    a => new BSObject(
                        ( decimal ) TerrainPaintUtility.FindTerrainLayerIndex(
                            WrapperHelper.UnwrapObject < Terrain >( a[0] ),
                            WrapperHelper.UnwrapObject < TerrainLayer >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

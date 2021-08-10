using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Experimental.TerrainAPI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext : BSWrapperObject < PaintContext >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext( PaintContext obj ) : base( obj )
        {
            m_Properties["originTerrain"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Terrain( m_InternalObject.originTerrain ),
                null );

            m_Properties["pixelRect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectInt( m_InternalObject.pixelRect ),
                null );

            m_Properties["targetTextureWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.targetTextureWidth ),
                null );

            m_Properties["targetTextureHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.targetTextureHeight ),
                null );

            m_Properties["pixelSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.pixelSize ),
                null );

            m_Properties["sourceRenderTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.sourceRenderTexture ),
                null );

            m_Properties["destinationRenderTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.destinationRenderTexture ),
                null );

            m_Properties["oldRenderTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.oldRenderTexture ),
                null );

            m_Properties["terrainCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.terrainCount ),
                null );

            m_Properties["heightWorldSpaceMin"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightWorldSpaceMin ),
                null );

            m_Properties["heightWorldSpaceSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightWorldSpaceSize ),
                null );

            m_Properties["GetTerrain"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTerrain(terrainIndex)",
                    a => new BSWrapperObject_UnityEngine_Terrain(
                        m_InternalObject.GetTerrain( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetClippedPixelRectInTerrainPixels"] = new BSFunctionReference(
                new BSFunction(
                    "function GetClippedPixelRectInTerrainPixels(terrainIndex)",
                    a => new BSWrapperObject_UnityEngine_RectInt(
                        m_InternalObject.GetClippedPixelRectInTerrainPixels(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetClippedPixelRectInRenderTexturePixels"] = new BSFunctionReference(
                new BSFunction(
                    "function GetClippedPixelRectInRenderTexturePixels(terrainIndex)",
                    a => new BSWrapperObject_UnityEngine_RectInt(
                        m_InternalObject.GetClippedPixelRectInRenderTexturePixels(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

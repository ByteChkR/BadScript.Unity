using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TerrainData : BSWrapperObject < TerrainData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TerrainData( TerrainData obj ) : base( obj )
        {
            m_Properties["heightmapWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightmapResolution ),
                null );

            m_Properties["heightmapHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightmapResolution ),
                null );

            m_Properties["heightmapTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.heightmapTexture ),
                null );

            m_Properties["heightmapResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightmapResolution ),
                x => m_InternalObject.heightmapResolution = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["heightmapScale"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.heightmapScale ),
                null );

            m_Properties["holesTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.holesTexture ),
                null );

            m_Properties["enableHolesTextureCompression"] = new BSReflectionReference(
                () => m_InternalObject.enableHolesTextureCompression ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableHolesTextureCompression = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["holesResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.holesResolution ),
                null );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                null );

            m_Properties["thickness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.thickness ),
                x => m_InternalObject.thickness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["wavingGrassStrength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.wavingGrassStrength ),
                x => m_InternalObject.wavingGrassStrength = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["wavingGrassAmount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.wavingGrassAmount ),
                x => m_InternalObject.wavingGrassAmount = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["wavingGrassSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.wavingGrassSpeed ),
                x => m_InternalObject.wavingGrassSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["wavingGrassTint"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.wavingGrassTint ),
                x => m_InternalObject.wavingGrassTint = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["detailWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.detailWidth ),
                null );

            m_Properties["detailHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.detailHeight ),
                null );

            m_Properties["detailPatchCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.detailPatchCount ),
                null );

            m_Properties["detailResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.detailResolution ),
                null );

            m_Properties["detailResolutionPerPatch"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.detailResolutionPerPatch ),
                null );

            m_Properties["treeInstanceCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.treeInstanceCount ),
                null );

            m_Properties["alphamapLayers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.alphamapLayers ),
                null );

            m_Properties["alphamapResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.alphamapResolution ),
                x => m_InternalObject.alphamapResolution = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["alphamapWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.alphamapWidth ),
                null );

            m_Properties["alphamapHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.alphamapHeight ),
                null );

            m_Properties["baseMapResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.baseMapResolution ),
                x => m_InternalObject.baseMapResolution = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["alphamapTextureCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.alphamapTextureCount ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHeight(x, y)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetHeight(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetInterpolatedHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInterpolatedHeight(x, y)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInterpolatedHeight(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_Properties["IsHole"] = new BSFunctionReference(
                new BSFunction(
                    "function IsHole(x, y)",
                    a => m_InternalObject.IsHole(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["GetSteepness"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSteepness(x, y)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetSteepness(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetInterpolatedNormal"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInterpolatedNormal(x, y)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetInterpolatedNormal(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetTreeInstance"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTreeInstance(index)",
                    a => new BSWrapperObject_UnityEngine_TreeInstance(
                        m_InternalObject.GetTreeInstance( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAlphamapTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAlphamapTexture(index)",
                    a => new BSWrapperObject_UnityEngine_Texture2D(
                        m_InternalObject.GetAlphamapTexture( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

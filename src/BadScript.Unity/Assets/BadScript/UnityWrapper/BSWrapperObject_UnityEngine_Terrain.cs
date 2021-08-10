using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Terrain : BSWrapperObject < Terrain >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Terrain( Terrain obj ) : base( obj )
        {
            m_Properties["terrainData"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TerrainData( m_InternalObject.terrainData ),
                x => m_InternalObject.terrainData = WrapperHelper.UnwrapObject < TerrainData >( x ) );

            m_Properties["treeDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.treeDistance ),
                x => m_InternalObject.treeDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["treeBillboardDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.treeBillboardDistance ),
                x => m_InternalObject.treeBillboardDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["treeCrossFadeLength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.treeCrossFadeLength ),
                x => m_InternalObject.treeCrossFadeLength = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["treeMaximumFullLODCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.treeMaximumFullLODCount ),
                x => m_InternalObject.treeMaximumFullLODCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["detailObjectDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.detailObjectDistance ),
                x => m_InternalObject.detailObjectDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["detailObjectDensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.detailObjectDensity ),
                x => m_InternalObject.detailObjectDensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["heightmapPixelError"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightmapPixelError ),
                x => m_InternalObject.heightmapPixelError = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["heightmapMaximumLOD"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightmapMaximumLOD ),
                x => m_InternalObject.heightmapMaximumLOD = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["basemapDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.basemapDistance ),
                x => m_InternalObject.basemapDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["lightmapIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightmapIndex ),
                x => m_InternalObject.lightmapIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["realtimeLightmapIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.realtimeLightmapIndex ),
                x => m_InternalObject.realtimeLightmapIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["lightmapScaleOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.lightmapScaleOffset ),
                x => m_InternalObject.lightmapScaleOffset = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["realtimeLightmapScaleOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.realtimeLightmapScaleOffset ),
                x => m_InternalObject.realtimeLightmapScaleOffset = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["freeUnusedRenderingResources"] = new BSReflectionReference(
                () => m_InternalObject.freeUnusedRenderingResources ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.freeUnusedRenderingResources = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["materialTemplate"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.materialTemplate ),
                x => m_InternalObject.materialTemplate = WrapperHelper.UnwrapObject < Material >( x ) );

            m_Properties["drawHeightmap"] = new BSReflectionReference(
                () => m_InternalObject.drawHeightmap ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.drawHeightmap = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["allowAutoConnect"] = new BSReflectionReference(
                () => m_InternalObject.allowAutoConnect ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.allowAutoConnect = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["groupingID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.groupingID ),
                x => m_InternalObject.groupingID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["drawInstanced"] = new BSReflectionReference(
                () => m_InternalObject.drawInstanced ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.drawInstanced = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["normalmapTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.normalmapTexture ),
                null );

            m_Properties["drawTreesAndFoliage"] = new BSReflectionReference(
                () => m_InternalObject.drawTreesAndFoliage ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.drawTreesAndFoliage = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["patchBoundsMultiplier"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.patchBoundsMultiplier ),
                x => m_InternalObject.patchBoundsMultiplier = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["treeLODBiasMultiplier"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.treeLODBiasMultiplier ),
                x => m_InternalObject.treeLODBiasMultiplier = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["collectDetailPatches"] = new BSReflectionReference(
                () => m_InternalObject.collectDetailPatches ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.collectDetailPatches = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["bakeLightProbesForTrees"] = new BSReflectionReference(
                () => m_InternalObject.bakeLightProbesForTrees ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bakeLightProbesForTrees = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["deringLightProbesForTrees"] = new BSReflectionReference(
                () => m_InternalObject.deringLightProbesForTrees ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.deringLightProbesForTrees = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["preserveTreePrototypeLayers"] = new BSReflectionReference(
                () => m_InternalObject.preserveTreePrototypeLayers ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.preserveTreePrototypeLayers = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["leftNeighbor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Terrain( m_InternalObject.leftNeighbor ),
                null );

            m_Properties["rightNeighbor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Terrain( m_InternalObject.rightNeighbor ),
                null );

            m_Properties["topNeighbor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Terrain( m_InternalObject.topNeighbor ),
                null );

            m_Properties["bottomNeighbor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Terrain( m_InternalObject.bottomNeighbor ),
                null );

            m_Properties["renderingLayerMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.renderingLayerMask ),
                x => m_InternalObject.renderingLayerMask = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["castShadows"] = new BSReflectionReference(
                () => m_InternalObject.castShadows ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.castShadows = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["legacySpecular"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.legacySpecular ),
                x => m_InternalObject.legacySpecular = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["legacyShininess"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.legacyShininess ),
                x => m_InternalObject.legacyShininess = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["SampleHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function SampleHeight(worldPosition)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.SampleHeight( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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

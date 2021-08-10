using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LightingSettings : BSWrapperObject < LightingSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LightingSettings( LightingSettings obj ) : base( obj )
        {
            m_Properties["bakedGI"] = new BSReflectionReference(
                () => m_InternalObject.bakedGI ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bakedGI = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["realtimeGI"] = new BSReflectionReference(
                () => m_InternalObject.realtimeGI ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.realtimeGI = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["realtimeEnvironmentLighting"] = new BSReflectionReference(
                () => m_InternalObject.realtimeEnvironmentLighting ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.realtimeEnvironmentLighting = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["autoGenerate"] = new BSReflectionReference(
                () => m_InternalObject.autoGenerate ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoGenerate = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["albedoBoost"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.albedoBoost ),
                x => m_InternalObject.albedoBoost = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["indirectScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indirectScale ),
                x => m_InternalObject.indirectScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["lightmapMaxSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightmapMaxSize ),
                x => m_InternalObject.lightmapMaxSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["lightmapResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightmapResolution ),
                x => m_InternalObject.lightmapResolution = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["lightmapPadding"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightmapPadding ),
                x => m_InternalObject.lightmapPadding = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["compressLightmaps"] = new BSReflectionReference(
                () => m_InternalObject.compressLightmaps ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.compressLightmaps = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["ao"] = new BSReflectionReference(
                () => m_InternalObject.ao ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.ao = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["aoMaxDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.aoMaxDistance ),
                x => m_InternalObject.aoMaxDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["aoExponentIndirect"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.aoExponentIndirect ),
                x => m_InternalObject.aoExponentIndirect = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["aoExponentDirect"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.aoExponentDirect ),
                x => m_InternalObject.aoExponentDirect = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["extractAO"] = new BSReflectionReference(
                () => m_InternalObject.extractAO ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.extractAO = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["exportTrainingData"] = new BSReflectionReference(
                () => m_InternalObject.exportTrainingData ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.exportTrainingData = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["trainingDataDestination"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.trainingDataDestination ),
                x => m_InternalObject.trainingDataDestination = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["indirectResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indirectResolution ),
                x => m_InternalObject.indirectResolution = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["finalGather"] = new BSReflectionReference(
                () => m_InternalObject.finalGather ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.finalGather = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["finalGatherRayCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.finalGatherRayCount ),
                x => m_InternalObject.finalGatherRayCount = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["finalGatherFiltering"] = new BSReflectionReference(
                () => m_InternalObject.finalGatherFiltering ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.finalGatherFiltering = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["directSampleCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.directSampleCount ),
                x => m_InternalObject.directSampleCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["indirectSampleCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indirectSampleCount ),
                x => m_InternalObject.indirectSampleCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["bounces"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxBounces ),
                x => m_InternalObject.maxBounces = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["maxBounces"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxBounces ),
                x => m_InternalObject.maxBounces = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["russianRouletteStartBounce"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minBounces ),
                x => m_InternalObject.minBounces = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["minBounces"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minBounces ),
                x => m_InternalObject.minBounces = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["prioritizeView"] = new BSReflectionReference(
                () => m_InternalObject.prioritizeView ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.prioritizeView = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["filteringGaussRadiusDirect"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.filteringGaussRadiusDirect ),
                x => m_InternalObject.filteringGaussRadiusDirect = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["filteringGaussRadiusIndirect"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.filteringGaussRadiusIndirect ),
                x => m_InternalObject.filteringGaussRadiusIndirect = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["filteringGaussRadiusAO"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.filteringGaussRadiusAO ),
                x => m_InternalObject.filteringGaussRadiusAO = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["filteringAtrousPositionSigmaDirect"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.filteringAtrousPositionSigmaDirect ),
                x => m_InternalObject.filteringAtrousPositionSigmaDirect = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["filteringAtrousPositionSigmaIndirect"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.filteringAtrousPositionSigmaIndirect ),
                x => m_InternalObject.filteringAtrousPositionSigmaIndirect =
                    WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["filteringAtrousPositionSigmaAO"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.filteringAtrousPositionSigmaAO ),
                x => m_InternalObject.filteringAtrousPositionSigmaAO = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["environmentSampleCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.environmentSampleCount ),
                x => m_InternalObject.environmentSampleCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["lightProbeSampleCountMultiplier"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightProbeSampleCountMultiplier ),
                x => m_InternalObject.lightProbeSampleCountMultiplier = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

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

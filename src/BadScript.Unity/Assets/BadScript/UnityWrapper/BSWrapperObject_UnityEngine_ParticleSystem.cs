using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ParticleSystem : BSWrapperObject < ParticleSystem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ParticleSystem( ParticleSystem obj ) : base( obj )
        {
            m_Properties["safeCollisionEventSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.GetSafeCollisionEventSize() ),
                null );

            m_Properties["startDelay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startDelay ),
                x => m_InternalObject.startDelay = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["loop"] = new BSReflectionReference(
                () => m_InternalObject.loop ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.loop = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["playOnAwake"] = new BSReflectionReference(
                () => m_InternalObject.playOnAwake ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.playOnAwake = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["duration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.duration ),
                null );

            m_Properties["playbackSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.playbackSpeed ),
                x => m_InternalObject.playbackSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["enableEmission"] = new BSReflectionReference(
                () => m_InternalObject.enableEmission ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableEmission = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["emissionRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.emissionRate ),
                x => m_InternalObject.emissionRate = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["startSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startSpeed ),
                x => m_InternalObject.startSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["startSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startSize ),
                x => m_InternalObject.startSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["startColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.startColor ),
                x => m_InternalObject.startColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["startRotation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startRotation ),
                x => m_InternalObject.startRotation = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["startRotation3D"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.startRotation3D ),
                x => m_InternalObject.startRotation3D = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["startLifetime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startLifetime ),
                x => m_InternalObject.startLifetime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["gravityModifier"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gravityModifier ),
                x => m_InternalObject.gravityModifier = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxParticles"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxParticles ),
                x => m_InternalObject.maxParticles = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["isPlaying"] = new BSReflectionReference(
                () => m_InternalObject.isPlaying ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isEmitting"] = new BSReflectionReference(
                () => m_InternalObject.isEmitting ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isStopped"] = new BSReflectionReference(
                () => m_InternalObject.isStopped ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isPaused"] = new BSReflectionReference(
                () => m_InternalObject.isPaused ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["particleCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.particleCount ),
                null );

            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                x => m_InternalObject.time = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["randomSeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.randomSeed ),
                x => m_InternalObject.randomSeed = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["useAutoRandomSeed"] = new BSReflectionReference(
                () => m_InternalObject.useAutoRandomSeed ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useAutoRandomSeed = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["proceduralSimulationSupported"] = new BSReflectionReference(
                () => m_InternalObject.proceduralSimulationSupported ? BSObject.One : BSObject.Zero,
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

            m_Properties["IsAlive"] = new BSFunctionReference(
                new BSFunction(
                    "function IsAlive(withChildren)",
                    a => m_InternalObject.IsAlive( WrapperHelper.UnwrapObject < bool >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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

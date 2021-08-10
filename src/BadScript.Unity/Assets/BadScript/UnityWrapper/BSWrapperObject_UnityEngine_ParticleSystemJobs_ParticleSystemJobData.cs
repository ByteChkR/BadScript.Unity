using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.ParticleSystemJobs;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemJobData : BSWrapperObject < ParticleSystemJobData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemJobData( ParticleSystemJobData obj ) : base(
            obj )
        {
            m_Properties["count"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.count ),
                null );

            m_Properties["positions"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray3(
                    m_InternalObject.positions ),
                null );

            m_Properties["velocities"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray3(
                    m_InternalObject.velocities ),
                null );

            m_Properties["axisOfRotations"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray3(
                    m_InternalObject.axisOfRotations ),
                null );

            m_Properties["rotations"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray3(
                    m_InternalObject.rotations ),
                null );

            m_Properties["rotationalSpeeds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray3(
                    m_InternalObject.rotationalSpeeds ),
                null );

            m_Properties["sizes"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray3(
                    m_InternalObject.sizes ),
                null );

            m_Properties["customData1"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray4(
                    m_InternalObject.customData1 ),
                null );

            m_Properties["customData2"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray4(
                    m_InternalObject.customData2 ),
                null );

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

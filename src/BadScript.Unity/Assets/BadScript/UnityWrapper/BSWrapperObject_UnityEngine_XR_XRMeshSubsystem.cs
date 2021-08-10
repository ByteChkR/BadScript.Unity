using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_XR_XRMeshSubsystem : BSWrapperObject < XRMeshSubsystem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_XRMeshSubsystem( XRMeshSubsystem obj ) : base( obj )
        {
            m_Properties["meshDensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.meshDensity ),
                x => m_InternalObject.meshDensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["subsystemDescriptor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_XR_XRMeshSubsystemDescriptor(
                    m_InternalObject.subsystemDescriptor ),
                null );

            m_Properties["SubsystemDescriptor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_XR_XRMeshSubsystemDescriptor(
                    m_InternalObject.SubsystemDescriptor ),
                null );

            m_Properties["running"] = new BSReflectionReference(
                () => m_InternalObject.running ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["SetBoundingVolume"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBoundingVolume(origin, extents)",
                    a => m_InternalObject.SetBoundingVolume(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

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

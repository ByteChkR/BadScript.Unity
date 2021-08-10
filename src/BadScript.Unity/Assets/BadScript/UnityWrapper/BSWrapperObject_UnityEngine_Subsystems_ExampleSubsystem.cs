using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Subsystems;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Subsystems_ExampleSubsystem : BSWrapperObject < ExampleSubsystem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Subsystems_ExampleSubsystem( ExampleSubsystem obj ) : base( obj )
        {
            m_Properties["subsystemDescriptor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Subsystems_ExampleSubsystemDescriptor(
                    m_InternalObject.subsystemDescriptor ),
                null );

            m_Properties["SubsystemDescriptor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Subsystems_ExampleSubsystemDescriptor(
                    m_InternalObject.SubsystemDescriptor ),
                null );

            m_Properties["running"] = new BSReflectionReference(
                () => m_InternalObject.running ? BSObject.One : BSObject.Zero,
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

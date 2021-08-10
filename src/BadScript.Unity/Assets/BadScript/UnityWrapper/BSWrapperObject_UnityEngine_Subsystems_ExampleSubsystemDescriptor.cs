using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Subsystems;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Subsystems_ExampleSubsystemDescriptor : BSWrapperObject < ExampleSubsystemDescriptor
        >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Subsystems_ExampleSubsystemDescriptor( ExampleSubsystemDescriptor obj ) :
            base( obj )
        {
            m_Properties["supportsEditorMode"] = new BSReflectionReference(
                () => m_InternalObject.supportsEditorMode ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["disableBackbufferMSAA"] = new BSReflectionReference(
                () => m_InternalObject.disableBackbufferMSAA ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["stereoscopicBackbuffer"] = new BSReflectionReference(
                () => m_InternalObject.stereoscopicBackbuffer ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["usePBufferEGL"] = new BSReflectionReference(
                () => m_InternalObject.usePBufferEGL ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["id"] = new BSReflectionReference( () => new BSObject( m_InternalObject.id ), null );

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

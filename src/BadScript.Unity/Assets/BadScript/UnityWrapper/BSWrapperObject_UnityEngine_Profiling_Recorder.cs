using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Profiling;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Profiling_Recorder : BSWrapperObject < Recorder >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Profiling_Recorder( Recorder obj ) : base( obj )
        {
            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["elapsedNanoseconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.elapsedNanoseconds ),
                null );

            m_Properties["gpuElapsedNanoseconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gpuElapsedNanoseconds ),
                null );

            m_Properties["sampleBlockCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sampleBlockCount ),
                null );

            m_Properties["gpuSampleBlockCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gpuSampleBlockCount ),
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
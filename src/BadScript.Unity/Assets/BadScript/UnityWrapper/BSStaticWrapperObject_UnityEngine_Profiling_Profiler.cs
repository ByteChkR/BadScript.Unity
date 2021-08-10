using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Profiling;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Profiling_Profiler : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Profiling_Profiler() : base( typeof( Profiler ) )
        {
            m_StaticProperties["supported"] = new BSReflectionReference(
                () => Profiler.supported ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["logFile"] = new BSReflectionReference(
                () => new BSObject( Profiler.logFile ),
                x => Profiler.logFile = WrapperHelper.UnwrapObject < string >( x ) );

            m_StaticProperties["enableBinaryLog"] = new BSReflectionReference(
                () => Profiler.enableBinaryLog ? BSObject.One : BSObject.Zero,
                x => Profiler.enableBinaryLog = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["maxUsedMemory"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Profiler.maxUsedMemory ),
                x => Profiler.maxUsedMemory = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["enabled"] = new BSReflectionReference(
                () => Profiler.enabled ? BSObject.One : BSObject.Zero,
                x => Profiler.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["enableAllocationCallstacks"] = new BSReflectionReference(
                () => Profiler.enableAllocationCallstacks ? BSObject.One : BSObject.Zero,
                x => Profiler.enableAllocationCallstacks = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["areaCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Profiler.areaCount ),
                null );

            m_StaticProperties["maxNumberOfSamplesPerFrame"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Profiler.maxNumberOfSamplesPerFrame ),
                x => Profiler.maxNumberOfSamplesPerFrame = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["usedHeapSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Profiler.usedHeapSize ),
                null );

            m_StaticProperties["usedHeapSizeLong"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Profiler.usedHeapSizeLong ),
                null );

            m_StaticProperties["GetRuntimeMemorySize"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRuntimeMemorySize(o)",
                    a => new BSObject(
                        ( decimal ) Profiler.GetRuntimeMemorySize( WrapperHelper.UnwrapObject < Object >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetRuntimeMemorySizeLong"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRuntimeMemorySizeLong(o)",
                    a => new BSObject(
                        ( decimal ) Profiler.GetRuntimeMemorySizeLong(
                            WrapperHelper.UnwrapObject < Object >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["SetTempAllocatorRequestedSize"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTempAllocatorRequestedSize(size)",
                    a => Profiler.SetTempAllocatorRequestedSize( WrapperHelper.UnwrapObject < uint >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

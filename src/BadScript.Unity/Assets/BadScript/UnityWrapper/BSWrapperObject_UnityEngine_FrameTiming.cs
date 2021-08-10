using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_FrameTiming : BSWrapperObject < FrameTiming >

    {
        #region Public

        public BSWrapperObject_UnityEngine_FrameTiming( FrameTiming obj ) : base( obj )
        {
            m_Properties["cpuTimePresentCalled"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cpuTimePresentCalled ),
                x => m_InternalObject.cpuTimePresentCalled = WrapperHelper.UnwrapObject < ulong >( x ) );

            m_Properties["cpuFrameTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cpuFrameTime ),
                x => m_InternalObject.cpuFrameTime = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["cpuTimeFrameComplete"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cpuTimeFrameComplete ),
                x => m_InternalObject.cpuTimeFrameComplete = WrapperHelper.UnwrapObject < ulong >( x ) );

            m_Properties["gpuFrameTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gpuFrameTime ),
                x => m_InternalObject.gpuFrameTime = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["heightScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightScale ),
                x => m_InternalObject.heightScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["widthScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.widthScale ),
                x => m_InternalObject.widthScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["syncInterval"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.syncInterval ),
                x => m_InternalObject.syncInterval = WrapperHelper.UnwrapObject < uint >( x ) );

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

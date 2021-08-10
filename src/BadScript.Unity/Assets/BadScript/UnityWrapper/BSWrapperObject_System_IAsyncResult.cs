using System;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_IAsyncResult : BSWrapperObject < IAsyncResult >

    {
        #region Public

        public BSWrapperObject_System_IAsyncResult( IAsyncResult obj ) : base( obj )
        {
            m_Properties["IsCompleted"] = new BSReflectionReference(
                () => m_InternalObject.IsCompleted ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["AsyncWaitHandle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_WaitHandle( m_InternalObject.AsyncWaitHandle ),
                null );

            m_Properties["AsyncState"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.AsyncState ),
                null );

            m_Properties["CompletedSynchronously"] = new BSReflectionReference(
                () => m_InternalObject.CompletedSynchronously ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

using System;
using System.IO;
using System.Threading;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_IO_FileStream : BSWrapperObject < FileStream >

    {
        #region Public

        public BSWrapperObject_System_IO_FileStream( FileStream obj ) : base( obj )
        {
            m_Properties["CanRead"] = new BSReflectionReference(
                () => m_InternalObject.CanRead ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["CanWrite"] = new BSReflectionReference(
                () => m_InternalObject.CanWrite ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["CanSeek"] = new BSReflectionReference(
                () => m_InternalObject.CanSeek ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsAsync"] = new BSReflectionReference(
                () => m_InternalObject.IsAsync ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Name ), null );

            m_Properties["Length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Length ),
                null );

            m_Properties["Position"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Position ),
                x => m_InternalObject.Position = WrapperHelper.UnwrapObject < long >( x ) );

            m_Properties["Handle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( m_InternalObject.Handle ),
                null );

            m_Properties["SafeFileHandle"] = new BSReflectionReference(
                () => new BSWrapperObject_Microsoft_Win32_SafeHandles_SafeFileHandle( m_InternalObject.SafeFileHandle ),
                null );

            m_Properties["CanTimeout"] = new BSReflectionReference(
                () => m_InternalObject.CanTimeout ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ReadTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ReadTimeout ),
                x => m_InternalObject.ReadTimeout = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["WriteTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.WriteTimeout ),
                x => m_InternalObject.WriteTimeout = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["EndRead"] = new BSFunctionReference(
                new BSFunction(
                    "function EndRead(asyncResult)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.EndRead( WrapperHelper.UnwrapObject < IAsyncResult >( a[0] ) ) ),
                    1 ) );

            m_Properties["FlushAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function FlushAsync(cancellationToken)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        m_InternalObject.FlushAsync( WrapperHelper.UnwrapObject < CancellationToken >( a[0] ) ) ),
                    1 ) );

            m_Properties["CopyToAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyToAsync(destination)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        m_InternalObject.CopyToAsync( WrapperHelper.UnwrapObject < Stream >( a[0] ) ) ),
                    1 ) );

            m_Properties["CopyToAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyToAsync(destination, bufferSize)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        m_InternalObject.CopyToAsync(
                            WrapperHelper.UnwrapObject < Stream >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["CopyToAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyToAsync(destination, bufferSize, cancellationToken)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        m_InternalObject.CopyToAsync(
                            WrapperHelper.UnwrapObject < Stream >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < CancellationToken >( a[2] ) ) ),
                    3 ) );

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

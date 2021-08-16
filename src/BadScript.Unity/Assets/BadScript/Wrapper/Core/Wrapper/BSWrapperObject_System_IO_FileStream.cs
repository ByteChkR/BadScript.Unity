using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_IO_FileStream : BSWrapperObject<System.IO.FileStream>

    {
        public BSWrapperObject_System_IO_FileStream(System.IO.FileStream obj) : base(obj)
        {
            m_Properties["CanRead"] = new BSReflectionReference(() => m_InternalObject.CanRead ? BSObject.One : BSObject.Zero, null);
            m_Properties["CanWrite"] = new BSReflectionReference(() => m_InternalObject.CanWrite ? BSObject.One : BSObject.Zero, null);
            m_Properties["CanSeek"] = new BSReflectionReference(() => m_InternalObject.CanSeek ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsAsync"] = new BSReflectionReference(() => m_InternalObject.IsAsync ? BSObject.One : BSObject.Zero, null);
            m_Properties["Name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.Name), null);
            m_Properties["Length"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Length), null);
            m_Properties["Position"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Position), x=> m_InternalObject.Position = WrapperHelper.UnwrapObject<System.Int64>(x));
            m_Properties["Handle"] = new BSReflectionReference(() => new BSWrapperObject_System_IntPtr(m_InternalObject.Handle), null);
            m_Properties["SafeFileHandle"] = new BSReflectionReference(() => new BSWrapperObject_Microsoft_Win32_SafeHandles_SafeFileHandle(m_InternalObject.SafeFileHandle), null);
            m_Properties["CanTimeout"] = new BSReflectionReference(() => m_InternalObject.CanTimeout ? BSObject.One : BSObject.Zero, null);
            m_Properties["ReadTimeout"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.ReadTimeout), x=> m_InternalObject.ReadTimeout = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["WriteTimeout"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.WriteTimeout), x=> m_InternalObject.WriteTimeout = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["ReadByte"] = new BSFunctionReference(new BSFunction("function ReadByte()", a => new BSObject((decimal)m_InternalObject.ReadByte()), 0));
            m_Properties["WriteByte"] = new BSFunctionReference(new BSFunction("function WriteByte(value)", a => {
                m_InternalObject.WriteByte(WrapperHelper.UnwrapObject<System.Byte>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["EndRead"] = new BSFunctionReference(new BSFunction("function EndRead(asyncResult)", a => new BSObject((decimal)m_InternalObject.EndRead(WrapperHelper.UnwrapObject<System.IAsyncResult>(a[0]))), 1));
            m_Properties["EndWrite"] = new BSFunctionReference(new BSFunction("function EndWrite(asyncResult)", a => {
                m_InternalObject.EndWrite(WrapperHelper.UnwrapObject<System.IAsyncResult>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SetLength"] = new BSFunctionReference(new BSFunction("function SetLength(value)", a => {
                m_InternalObject.SetLength(WrapperHelper.UnwrapObject<System.Int64>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Flush"] = new BSFunctionReference(new BSFunction("function Flush()", a => {
                m_InternalObject.Flush();
                return new BSObject(null);
            }, 0));
            m_Properties["Flush"] = new BSFunctionReference(new BSFunction("function Flush(flushToDisk)", a => {
                m_InternalObject.Flush(WrapperHelper.UnwrapObject<System.Boolean>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Lock"] = new BSFunctionReference(new BSFunction("function Lock(position, length)", a => {
                m_InternalObject.Lock(WrapperHelper.UnwrapObject<System.Int64>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Unlock"] = new BSFunctionReference(new BSFunction("function Unlock(position, length)", a => {
                m_InternalObject.Unlock(WrapperHelper.UnwrapObject<System.Int64>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["FlushAsync"] = new BSFunctionReference(new BSFunction("function FlushAsync(cancellationToken)", a => new BSWrapperObject_System_Threading_Tasks_Task(m_InternalObject.FlushAsync(WrapperHelper.UnwrapObject<System.Threading.CancellationToken>(a[0]))), 1));
            m_Properties["CopyToAsync"] = new BSFunctionReference(new BSFunction("function CopyToAsync(destination)", a => new BSWrapperObject_System_Threading_Tasks_Task(m_InternalObject.CopyToAsync(WrapperHelper.UnwrapObject<System.IO.Stream>(a[0]))), 1));
            m_Properties["CopyToAsync"] = new BSFunctionReference(new BSFunction("function CopyToAsync(destination, bufferSize)", a => new BSWrapperObject_System_Threading_Tasks_Task(m_InternalObject.CopyToAsync(WrapperHelper.UnwrapObject<System.IO.Stream>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["CopyToAsync"] = new BSFunctionReference(new BSFunction("function CopyToAsync(destination, bufferSize, cancellationToken)", a => new BSWrapperObject_System_Threading_Tasks_Task(m_InternalObject.CopyToAsync(WrapperHelper.UnwrapObject<System.IO.Stream>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Threading.CancellationToken>(a[2]))), 3));
            m_Properties["CopyTo"] = new BSFunctionReference(new BSFunction("function CopyTo(destination)", a => {
                m_InternalObject.CopyTo(WrapperHelper.UnwrapObject<System.IO.Stream>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["CopyTo"] = new BSFunctionReference(new BSFunction("function CopyTo(destination, bufferSize)", a => {
                m_InternalObject.CopyTo(WrapperHelper.UnwrapObject<System.IO.Stream>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Close"] = new BSFunctionReference(new BSFunction("function Close()", a => {
                m_InternalObject.Close();
                return new BSObject(null);
            }, 0));
            m_Properties["Dispose"] = new BSFunctionReference(new BSFunction("function Dispose()", a => {
                m_InternalObject.Dispose();
                return new BSObject(null);
            }, 0));
            m_Properties["FlushAsync"] = new BSFunctionReference(new BSFunction("function FlushAsync()", a => new BSWrapperObject_System_Threading_Tasks_Task(m_InternalObject.FlushAsync()), 0));
            m_Properties["GetLifetimeService"] = new BSFunctionReference(new BSFunction("function GetLifetimeService()", a => new BSWrapperObject_System_Object(m_InternalObject.GetLifetimeService()), 0));
            m_Properties["InitializeLifetimeService"] = new BSFunctionReference(new BSFunction("function InitializeLifetimeService()", a => new BSWrapperObject_System_Object(m_InternalObject.InitializeLifetimeService()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
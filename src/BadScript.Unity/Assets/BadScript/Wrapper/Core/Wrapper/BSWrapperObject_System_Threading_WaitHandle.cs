using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Threading_WaitHandle : BSWrapperObject<System.Threading.WaitHandle>

    {
        public BSWrapperObject_System_Threading_WaitHandle(System.Threading.WaitHandle obj) : base(obj)
        {
            m_Properties["Handle"] = new BSReflectionReference(() => new BSWrapperObject_System_IntPtr(m_InternalObject.Handle), x=> m_InternalObject.Handle = WrapperHelper.UnwrapObject<System.IntPtr>(x));
            m_Properties["SafeWaitHandle"] = new BSReflectionReference(() => new BSWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle(m_InternalObject.SafeWaitHandle), x=> m_InternalObject.SafeWaitHandle = WrapperHelper.UnwrapObject<Microsoft.Win32.SafeHandles.SafeWaitHandle>(x));
            m_Properties["WaitOne"] = new BSFunctionReference(new BSFunction("function WaitOne(millisecondsTimeout, exitContext)", a => m_InternalObject.WaitOne(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["WaitOne"] = new BSFunctionReference(new BSFunction("function WaitOne(timeout, exitContext)", a => m_InternalObject.WaitOne(WrapperHelper.UnwrapObject<System.TimeSpan>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["WaitOne"] = new BSFunctionReference(new BSFunction("function WaitOne()", a => m_InternalObject.WaitOne() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["WaitOne"] = new BSFunctionReference(new BSFunction("function WaitOne(millisecondsTimeout)", a => m_InternalObject.WaitOne(WrapperHelper.UnwrapObject<System.Int32>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["WaitOne"] = new BSFunctionReference(new BSFunction("function WaitOne(timeout)", a => m_InternalObject.WaitOne(WrapperHelper.UnwrapObject<System.TimeSpan>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Close"] = new BSFunctionReference(new BSFunction("function Close()", a => {
                m_InternalObject.Close();
                return new BSObject(null);
            }, 0));
            m_Properties["Dispose"] = new BSFunctionReference(new BSFunction("function Dispose()", a => {
                m_InternalObject.Dispose();
                return new BSObject(null);
            }, 0));
            m_Properties["GetLifetimeService"] = new BSFunctionReference(new BSFunction("function GetLifetimeService()", a => new BSWrapperObject_System_Object(m_InternalObject.GetLifetimeService()), 0));
            m_Properties["InitializeLifetimeService"] = new BSFunctionReference(new BSFunction("function InitializeLifetimeService()", a => new BSWrapperObject_System_Object(m_InternalObject.InitializeLifetimeService()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
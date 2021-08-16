using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_IntPtr : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_IntPtr() : base(typeof(System.IntPtr))
        {
            m_StaticProperties["Size"] = new BSReflectionReference(() => new BSObject((decimal)System.IntPtr.Size), null);
            m_StaticProperties["Zero"] = new BSReflectionReference(() => new BSWrapperObject_System_IntPtr(System.IntPtr.Zero), null);
            m_StaticProperties["Add"] = new BSFunctionReference(new BSFunction("function Add(pointer, offset)", a => new BSWrapperObject_System_IntPtr(System.IntPtr.Add(WrapperHelper.UnwrapObject<System.IntPtr>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_StaticProperties["Subtract"] = new BSFunctionReference(new BSFunction("function Subtract(pointer, offset)", a => new BSWrapperObject_System_IntPtr(System.IntPtr.Subtract(WrapperHelper.UnwrapObject<System.IntPtr>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));

        }
    }

}
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_IO_Stream : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_IO_Stream() : base(typeof(System.IO.Stream))
        {
            m_StaticProperties["Null"] = new BSReflectionReference(() => new BSWrapperObject_System_IO_Stream(System.IO.Stream.Null), null);
            m_StaticProperties["Synchronized"] = new BSFunctionReference(new BSFunction("function Synchronized(stream)", a => new BSWrapperObject_System_IO_Stream(System.IO.Stream.Synchronized(WrapperHelper.UnwrapObject<System.IO.Stream>(a[0]))), 1));

        }
    }

}
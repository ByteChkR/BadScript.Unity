using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_ModuleHandle : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_ModuleHandle() : base(typeof(System.ModuleHandle))
        {
            m_StaticProperties["EmptyHandle"] = new BSReflectionReference(() => new BSWrapperObject_System_ModuleHandle(System.ModuleHandle.EmptyHandle), null);

        }
    }

}
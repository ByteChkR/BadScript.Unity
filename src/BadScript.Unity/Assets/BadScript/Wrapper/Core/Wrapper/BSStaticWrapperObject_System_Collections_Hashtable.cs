using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Collections_Hashtable : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Collections_Hashtable() : base(typeof(System.Collections.Hashtable))
        {
            m_StaticProperties["Synchronized"] = new BSFunctionReference(new BSFunction("function Synchronized(table)", a => new BSWrapperObject_System_Collections_Hashtable(System.Collections.Hashtable.Synchronized(WrapperHelper.UnwrapObject<System.Collections.Hashtable>(a[0]))), 1));

        }
    }

}
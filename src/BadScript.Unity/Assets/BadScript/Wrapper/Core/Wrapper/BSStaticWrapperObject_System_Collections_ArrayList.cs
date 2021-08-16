using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Collections_ArrayList : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Collections_ArrayList() : base(typeof(System.Collections.ArrayList))
        {
            m_StaticProperties["Adapter"] = new BSFunctionReference(new BSFunction("function Adapter(list)", a => new BSWrapperObject_System_Collections_ArrayList(System.Collections.ArrayList.Adapter(WrapperHelper.UnwrapObject<System.Collections.IList>(a[0]))), 1));
            m_StaticProperties["FixedSize"] = new BSFunctionReference(new BSFunction("function FixedSize(list)", a => new BSWrapperObject_System_Collections_IList(System.Collections.ArrayList.FixedSize(WrapperHelper.UnwrapObject<System.Collections.IList>(a[0]))), 1));
            m_StaticProperties["FixedSize"] = new BSFunctionReference(new BSFunction("function FixedSize(list)", a => new BSWrapperObject_System_Collections_ArrayList(System.Collections.ArrayList.FixedSize(WrapperHelper.UnwrapObject<System.Collections.ArrayList>(a[0]))), 1));
            m_StaticProperties["ReadOnly"] = new BSFunctionReference(new BSFunction("function ReadOnly(list)", a => new BSWrapperObject_System_Collections_IList(System.Collections.ArrayList.ReadOnly(WrapperHelper.UnwrapObject<System.Collections.IList>(a[0]))), 1));
            m_StaticProperties["ReadOnly"] = new BSFunctionReference(new BSFunction("function ReadOnly(list)", a => new BSWrapperObject_System_Collections_ArrayList(System.Collections.ArrayList.ReadOnly(WrapperHelper.UnwrapObject<System.Collections.ArrayList>(a[0]))), 1));
            m_StaticProperties["Repeat"] = new BSFunctionReference(new BSFunction("function Repeat(value, count)", a => new BSWrapperObject_System_Collections_ArrayList(System.Collections.ArrayList.Repeat(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_StaticProperties["Synchronized"] = new BSFunctionReference(new BSFunction("function Synchronized(list)", a => new BSWrapperObject_System_Collections_IList(System.Collections.ArrayList.Synchronized(WrapperHelper.UnwrapObject<System.Collections.IList>(a[0]))), 1));
            m_StaticProperties["Synchronized"] = new BSFunctionReference(new BSFunction("function Synchronized(list)", a => new BSWrapperObject_System_Collections_ArrayList(System.Collections.ArrayList.Synchronized(WrapperHelper.UnwrapObject<System.Collections.ArrayList>(a[0]))), 1));

        }
    }

}
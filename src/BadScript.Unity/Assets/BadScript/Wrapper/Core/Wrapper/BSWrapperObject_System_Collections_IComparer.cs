using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_IComparer : BSWrapperObject<System.Collections.IComparer>

    {
        public BSWrapperObject_System_Collections_IComparer(System.Collections.IComparer obj) : base(obj)
        {
            m_Properties["Compare"] = new BSFunctionReference(new BSFunction("function Compare(x, y)", a => new BSObject((decimal)m_InternalObject.Compare(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]))), 2));

        }
    }

}
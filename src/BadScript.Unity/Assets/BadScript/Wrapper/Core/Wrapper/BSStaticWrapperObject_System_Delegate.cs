using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Delegate : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Delegate() : base(typeof(System.Delegate))
        {
            m_StaticProperties["Combine"] = new BSFunctionReference(new BSFunction("function Combine(a, b)", a => new BSWrapperObject_System_Delegate(System.Delegate.Combine(WrapperHelper.UnwrapObject<System.Delegate>(a[0]), WrapperHelper.UnwrapObject<System.Delegate>(a[1]))), 2));
            m_StaticProperties["Remove"] = new BSFunctionReference(new BSFunction("function Remove(source, value)", a => new BSWrapperObject_System_Delegate(System.Delegate.Remove(WrapperHelper.UnwrapObject<System.Delegate>(a[0]), WrapperHelper.UnwrapObject<System.Delegate>(a[1]))), 2));
            m_StaticProperties["RemoveAll"] = new BSFunctionReference(new BSFunction("function RemoveAll(source, value)", a => new BSWrapperObject_System_Delegate(System.Delegate.RemoveAll(WrapperHelper.UnwrapObject<System.Delegate>(a[0]), WrapperHelper.UnwrapObject<System.Delegate>(a[1]))), 2));

        }
    }

}
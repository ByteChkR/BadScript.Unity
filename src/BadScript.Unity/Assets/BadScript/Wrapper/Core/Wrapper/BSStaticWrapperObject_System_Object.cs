using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Object : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Object() : base(typeof(System.Object))
        {
            m_StaticProperties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(objA, objB)", a => System.Object.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["ReferenceEquals"] = new BSFunctionReference(new BSFunction("function ReferenceEquals(objA, objB)", a => System.Object.ReferenceEquals(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1])) ? BSObject.One : BSObject.Zero, 2));

        }
    }

}
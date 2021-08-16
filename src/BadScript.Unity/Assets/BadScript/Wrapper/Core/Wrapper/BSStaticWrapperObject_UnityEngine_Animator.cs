using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Animator : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Animator() : base(typeof(UnityEngine.Animator))
        {
            m_StaticProperties["StringToHash"] = new BSFunctionReference(new BSFunction("function StringToHash(name)", a => new BSObject((decimal)UnityEngine.Animator.StringToHash(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
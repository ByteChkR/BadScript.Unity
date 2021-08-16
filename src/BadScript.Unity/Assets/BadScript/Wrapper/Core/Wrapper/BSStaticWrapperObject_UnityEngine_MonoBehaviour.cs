using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_MonoBehaviour : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_MonoBehaviour() : base(typeof(UnityEngine.MonoBehaviour))
        {
            m_StaticProperties["print"] = new BSFunctionReference(new BSFunction("function print(message)", a => {
                UnityEngine.MonoBehaviour.print(WrapperHelper.UnwrapObject<System.Object>(a[0]));
                return new BSObject(null);
            }, 1));

        }
    }

}
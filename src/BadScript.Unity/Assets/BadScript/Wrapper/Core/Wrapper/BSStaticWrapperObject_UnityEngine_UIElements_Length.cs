using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Length : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UIElements_Length() : base(typeof(UnityEngine.UIElements.Length))
        {
            m_StaticProperties["Percent"] = new BSFunctionReference(new BSFunction("function Percent(value)", a => new BSWrapperObject_UnityEngine_UIElements_Length(UnityEngine.UIElements.Length.Percent(WrapperHelper.UnwrapObject<System.Single>(a[0]))), 1));

        }
    }

}
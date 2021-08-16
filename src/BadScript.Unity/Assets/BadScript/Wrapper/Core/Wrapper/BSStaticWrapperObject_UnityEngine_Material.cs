using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Material : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Material() : base(typeof(UnityEngine.Material))
        {
            m_StaticProperties["Create"] = new BSFunctionReference(new BSFunction("function Create(scriptContents)", a => new BSWrapperObject_UnityEngine_Material(UnityEngine.Material.Create(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
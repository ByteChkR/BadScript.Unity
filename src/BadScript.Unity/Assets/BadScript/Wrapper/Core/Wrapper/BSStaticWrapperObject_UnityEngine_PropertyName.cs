using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_PropertyName : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_PropertyName() : base(typeof(UnityEngine.PropertyName))
        {
            m_StaticProperties["IsNullOrEmpty"] = new BSFunctionReference(new BSFunction("function IsNullOrEmpty(prop)", a => UnityEngine.PropertyName.IsNullOrEmpty(WrapperHelper.UnwrapObject<UnityEngine.PropertyName>(a[0])) ? BSObject.One : BSObject.Zero, 1));

        }
    }

}
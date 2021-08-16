using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Background : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UIElements_Background() : base(typeof(UnityEngine.UIElements.Background))
        {
            m_StaticProperties["FromTexture2D"] = new BSFunctionReference(new BSFunction("function FromTexture2D(t)", a => new BSWrapperObject_UnityEngine_UIElements_Background(UnityEngine.UIElements.Background.FromTexture2D(WrapperHelper.UnwrapObject<UnityEngine.Texture2D>(a[0]))), 1));
            m_StaticProperties["FromVectorImage"] = new BSFunctionReference(new BSFunction("function FromVectorImage(vi)", a => new BSWrapperObject_UnityEngine_UIElements_Background(UnityEngine.UIElements.Background.FromVectorImage(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VectorImage>(a[0]))), 1));

        }
    }

}
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Font : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Font() : base(typeof(UnityEngine.Font))
        {
            m_StaticProperties["CreateDynamicFontFromOSFont"] = new BSFunctionReference(new BSFunction("function CreateDynamicFontFromOSFont(fontname, size)", a => new BSWrapperObject_UnityEngine_Font(UnityEngine.Font.CreateDynamicFontFromOSFont(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_StaticProperties["GetMaxVertsForString"] = new BSFunctionReference(new BSFunction("function GetMaxVertsForString(str)", a => new BSObject((decimal)UnityEngine.Font.GetMaxVertsForString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
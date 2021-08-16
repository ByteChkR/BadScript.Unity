using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Canvas : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Canvas() : base(typeof(UnityEngine.Canvas))
        {
            m_StaticProperties["GetDefaultCanvasTextMaterial"] = new BSFunctionReference(new BSFunction("function GetDefaultCanvasTextMaterial()", a => new BSWrapperObject_UnityEngine_Material(UnityEngine.Canvas.GetDefaultCanvasTextMaterial()), 0));
            m_StaticProperties["GetDefaultCanvasMaterial"] = new BSFunctionReference(new BSFunction("function GetDefaultCanvasMaterial()", a => new BSWrapperObject_UnityEngine_Material(UnityEngine.Canvas.GetDefaultCanvasMaterial()), 0));
            m_StaticProperties["GetETC1SupportedCanvasMaterial"] = new BSFunctionReference(new BSFunction("function GetETC1SupportedCanvasMaterial()", a => new BSWrapperObject_UnityEngine_Material(UnityEngine.Canvas.GetETC1SupportedCanvasMaterial()), 0));
            m_StaticProperties["ForceUpdateCanvases"] = new BSFunctionReference(new BSFunction("function ForceUpdateCanvases()", a => {
                UnityEngine.Canvas.ForceUpdateCanvases();
                return new BSObject(null);
            }, 0));

        }
    }

}
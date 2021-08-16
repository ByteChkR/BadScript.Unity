using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Canvas : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Canvas() : base( typeof( Canvas ) )
        {
            m_StaticProperties["GetDefaultCanvasTextMaterial"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDefaultCanvasTextMaterial()",
                    a => new BSWrapperObject_UnityEngine_Material( Canvas.GetDefaultCanvasTextMaterial() ),
                    0 ) );

            m_StaticProperties["GetDefaultCanvasMaterial"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDefaultCanvasMaterial()",
                    a => new BSWrapperObject_UnityEngine_Material( Canvas.GetDefaultCanvasMaterial() ),
                    0 ) );

            m_StaticProperties["GetETC1SupportedCanvasMaterial"] = new BSFunctionReference(
                new BSFunction(
                    "function GetETC1SupportedCanvasMaterial()",
                    a => new BSWrapperObject_UnityEngine_Material( Canvas.GetETC1SupportedCanvasMaterial() ),
                    0 ) );

            m_StaticProperties["ForceUpdateCanvases"] = new BSFunctionReference(
                new BSFunction(
                    "function ForceUpdateCanvases()",
                    a =>
                    {
                        Canvas.ForceUpdateCanvases();

                        return new BSObject( null );
                    },
                    0 ) );

        }

        #endregion
    }

}

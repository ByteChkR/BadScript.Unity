using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UI_CanvasUpdateRegistry : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_CanvasUpdateRegistry() : base( typeof( CanvasUpdateRegistry ) )
        {
            m_StaticProperties["instance"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_CanvasUpdateRegistry( CanvasUpdateRegistry.instance ),
                null );

            m_StaticProperties["TryRegisterCanvasElementForLayoutRebuild"] = new BSFunctionReference(
                new BSFunction(
                    "function TryRegisterCanvasElementForLayoutRebuild(element)",
                    a => CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild(
                        WrapperHelper.UnwrapObject < ICanvasElement >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["TryRegisterCanvasElementForGraphicRebuild"] = new BSFunctionReference(
                new BSFunction(
                    "function TryRegisterCanvasElementForGraphicRebuild(element)",
                    a => CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild(
                        WrapperHelper.UnwrapObject < ICanvasElement >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

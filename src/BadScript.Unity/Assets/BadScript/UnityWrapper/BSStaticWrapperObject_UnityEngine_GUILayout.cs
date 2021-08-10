using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_GUILayout : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_GUILayout() : base( typeof( GUILayout ) )
        {
            m_StaticProperties["BeginScrollView"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginScrollView(scrollPosition, style)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        GUILayout.BeginScrollView(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Width"] = new BSFunctionReference(
                new BSFunction(
                    "function Width(width)",
                    a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                        GUILayout.Width( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["MinWidth"] = new BSFunctionReference(
                new BSFunction(
                    "function MinWidth(minWidth)",
                    a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                        GUILayout.MinWidth( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["MaxWidth"] = new BSFunctionReference(
                new BSFunction(
                    "function MaxWidth(maxWidth)",
                    a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                        GUILayout.MaxWidth( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Height"] = new BSFunctionReference(
                new BSFunction(
                    "function Height(height)",
                    a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                        GUILayout.Height( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["MinHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function MinHeight(minHeight)",
                    a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                        GUILayout.MinHeight( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["MaxHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function MaxHeight(maxHeight)",
                    a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                        GUILayout.MaxHeight( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ExpandWidth"] = new BSFunctionReference(
                new BSFunction(
                    "function ExpandWidth(expand)",
                    a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                        GUILayout.ExpandWidth( WrapperHelper.UnwrapObject < bool >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ExpandHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function ExpandHeight(expand)",
                    a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                        GUILayout.ExpandHeight( WrapperHelper.UnwrapObject < bool >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_GUILayoutUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_GUILayoutUtility() : base( typeof( GUILayoutUtility ) )
        {
            m_StaticProperties["GetRect"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRect(content, style)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUILayoutUtility.GetRect(
                            WrapperHelper.UnwrapObject < GUIContent >( a[0] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetRect"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRect(width, height)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUILayoutUtility.GetRect(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetRect"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRect(width, height, style)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUILayoutUtility.GetRect(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetRect"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRect(minWidth, maxWidth, minHeight, maxHeight)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUILayoutUtility.GetRect(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["GetRect"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRect(minWidth, maxWidth, minHeight, maxHeight, style)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUILayoutUtility.GetRect(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["GetAspectRect"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAspectRect(aspect)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUILayoutUtility.GetAspectRect( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAspectRect"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAspectRect(aspect, style)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUILayoutUtility.GetAspectRect(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

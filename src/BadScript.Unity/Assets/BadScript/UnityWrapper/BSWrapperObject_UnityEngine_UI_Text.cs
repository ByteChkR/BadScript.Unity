using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_Text : BSWrapperObject < Text >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_Text( Text obj ) : base( obj )
        {
            m_Properties["cachedTextGenerator"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TextGenerator( m_InternalObject.cachedTextGenerator ),
                null );

            m_Properties["cachedTextGeneratorForLayout"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TextGenerator( m_InternalObject.cachedTextGeneratorForLayout ),
                null );

            m_Properties["mainTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.mainTexture ),
                null );

            m_Properties["font"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Font( m_InternalObject.font ),
                x => m_InternalObject.font = WrapperHelper.UnwrapObject < Font >( x ) );

            m_Properties["text"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.text ),
                x => m_InternalObject.text = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["supportRichText"] = new BSReflectionReference(
                () => m_InternalObject.supportRichText ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.supportRichText = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["resizeTextForBestFit"] = new BSReflectionReference(
                () => m_InternalObject.resizeTextForBestFit ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.resizeTextForBestFit = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["resizeTextMinSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.resizeTextMinSize ),
                x => m_InternalObject.resizeTextMinSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["resizeTextMaxSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.resizeTextMaxSize ),
                x => m_InternalObject.resizeTextMaxSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["alignByGeometry"] = new BSReflectionReference(
                () => m_InternalObject.alignByGeometry ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.alignByGeometry = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["fontSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fontSize ),
                x => m_InternalObject.fontSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["lineSpacing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lineSpacing ),
                x => m_InternalObject.lineSpacing = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["pixelsPerUnit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pixelsPerUnit ),
                null );

            m_Properties["minWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minWidth ),
                null );

            m_Properties["preferredWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.preferredWidth ),
                null );

            m_Properties["flexibleWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.flexibleWidth ),
                null );

            m_Properties["minHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minHeight ),
                null );

            m_Properties["preferredHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.preferredHeight ),
                null );

            m_Properties["flexibleHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.flexibleHeight ),
                null );

            m_Properties["layoutPriority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layoutPriority ),
                null );

            m_Properties["maskable"] = new BSReflectionReference(
                () => m_InternalObject.maskable ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.maskable = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isMaskingGraphic"] = new BSReflectionReference(
                () => m_InternalObject.isMaskingGraphic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isMaskingGraphic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["raycastTarget"] = new BSReflectionReference(
                () => m_InternalObject.raycastTarget ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.raycastTarget = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["raycastPadding"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.raycastPadding ),
                x => m_InternalObject.raycastPadding = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["depth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.depth ),
                null );

            m_Properties["rectTransform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectTransform( m_InternalObject.rectTransform ),
                null );

            m_Properties["canvas"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Canvas( m_InternalObject.canvas ),
                null );

            m_Properties["canvasRenderer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_CanvasRenderer( m_InternalObject.canvasRenderer ),
                null );

            m_Properties["defaultMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.defaultMaterial ),
                null );

            m_Properties["material"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.material ),
                x => m_InternalObject.material = WrapperHelper.UnwrapObject < Material >( x ) );

            m_Properties["materialForRendering"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.materialForRendering ),
                null );

            m_Properties["useGUILayout"] = new BSReflectionReference(
                () => m_InternalObject.useGUILayout ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useGUILayout = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["runInEditMode"] = new BSReflectionReference(
                () => m_InternalObject.runInEditMode ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.runInEditMode = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetGenerationSettings"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGenerationSettings(extents)",
                    a => new BSWrapperObject_UnityEngine_TextGenerationSettings(
                        m_InternalObject.GetGenerationSettings( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetModifiedMaterial"] = new BSFunctionReference(
                new BSFunction(
                    "function GetModifiedMaterial(baseMaterial)",
                    a => new BSWrapperObject_UnityEngine_Material(
                        m_InternalObject.GetModifiedMaterial( WrapperHelper.UnwrapObject < Material >( a[0] ) ) ),
                    1 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(sp, eventCamera)",
                    a => m_InternalObject.Raycast(
                        WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                        WrapperHelper.UnwrapObject < Camera >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["PixelAdjustPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function PixelAdjustPoint(point)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.PixelAdjustPoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsInvoking"] = new BSFunctionReference(
                new BSFunction(
                    "function IsInvoking(methodName)",
                    a => m_InternalObject.IsInvoking( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(methodName)",
                    a => new BSWrapperObject_UnityEngine_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(methodName, value)",
                    a => new BSWrapperObject_UnityEngine_Coroutine(
                        m_InternalObject.StartCoroutine(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(routine)",
                    a => new BSWrapperObject_UnityEngine_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < IEnumerator >( a[0] ) ) ),
                    1 ) );

            m_Properties["StartCoroutine_Auto"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine_Auto(routine)",
                    a => new BSWrapperObject_UnityEngine_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < IEnumerator >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
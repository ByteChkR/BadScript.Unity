using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Screen : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Screen() : base( typeof( Screen ) )
        {
            m_StaticProperties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Screen.width ),
                null );

            m_StaticProperties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Screen.height ),
                null );

            m_StaticProperties["dpi"] = new BSReflectionReference( () => new BSObject( ( decimal ) Screen.dpi ), null );

            m_StaticProperties["currentResolution"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Resolution( Screen.currentResolution ),
                null );

            m_StaticProperties["fullScreen"] = new BSReflectionReference(
                () => Screen.fullScreen ? BSObject.One : BSObject.Zero,
                x => Screen.fullScreen = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["safeArea"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( Screen.safeArea ),
                null );

            m_StaticProperties["autorotateToPortrait"] = new BSReflectionReference(
                () => Screen.autorotateToPortrait ? BSObject.One : BSObject.Zero,
                x => Screen.autorotateToPortrait = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autorotateToPortraitUpsideDown"] = new BSReflectionReference(
                () => Screen.autorotateToPortraitUpsideDown ? BSObject.One : BSObject.Zero,
                x => Screen.autorotateToPortraitUpsideDown = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autorotateToLandscapeLeft"] = new BSReflectionReference(
                () => Screen.autorotateToLandscapeLeft ? BSObject.One : BSObject.Zero,
                x => Screen.autorotateToLandscapeLeft = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autorotateToLandscapeRight"] = new BSReflectionReference(
                () => Screen.autorotateToLandscapeRight ? BSObject.One : BSObject.Zero,
                x => Screen.autorotateToLandscapeRight = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["sleepTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Screen.sleepTimeout ),
                x => Screen.sleepTimeout = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["brightness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Screen.brightness ),
                x => Screen.brightness = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["lockCursor"] = new BSReflectionReference(
                () => Screen.lockCursor ? BSObject.One : BSObject.Zero,
                x => Screen.lockCursor = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}

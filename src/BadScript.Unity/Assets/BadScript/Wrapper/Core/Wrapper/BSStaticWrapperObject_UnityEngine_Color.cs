using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Color : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Color() : base( typeof( Color ) )
        {
            m_StaticProperties["red"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.red ),
                null );

            m_StaticProperties["green"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.green ),
                null );

            m_StaticProperties["blue"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.blue ),
                null );

            m_StaticProperties["white"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.white ),
                null );

            m_StaticProperties["black"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.black ),
                null );

            m_StaticProperties["yellow"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.yellow ),
                null );

            m_StaticProperties["cyan"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.cyan ),
                null );

            m_StaticProperties["magenta"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.magenta ),
                null );

            m_StaticProperties["gray"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.gray ),
                null );

            m_StaticProperties["grey"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.grey ),
                null );

            m_StaticProperties["clear"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Color.clear ),
                null );

            m_StaticProperties["Lerp"] = new BSFunctionReference(
                new BSFunction(
                    "function Lerp(a, b, t)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Color.Lerp(
                            WrapperHelper.UnwrapObject < Color >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(
                new BSFunction(
                    "function LerpUnclamped(a, b, t)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Color.LerpUnclamped(
                            WrapperHelper.UnwrapObject < Color >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["HSVToRGB"] = new BSFunctionReference(
                new BSFunction(
                    "function HSVToRGB(H, S, V)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Color.HSVToRGB(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["HSVToRGB"] = new BSFunctionReference(
                new BSFunction(
                    "function HSVToRGB(H, S, V, hdr)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Color.HSVToRGB(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < bool >( a[3] ) ) ),
                    4 ) );

        }

        #endregion
    }

}

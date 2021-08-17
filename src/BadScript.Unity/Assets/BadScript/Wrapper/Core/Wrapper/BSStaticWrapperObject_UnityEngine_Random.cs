using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

#pragma warning disable 618
namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Random : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Random() : base( typeof( Random ) )
        {
            m_StaticProperties["value"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Random.value ),
                null );

            m_StaticProperties["insideUnitSphere"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( Random.insideUnitSphere ),
                null );

            m_StaticProperties["insideUnitCircle"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Random.insideUnitCircle ),
                null );

            m_StaticProperties["onUnitSphere"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( Random.onUnitSphere ),
                null );

            m_StaticProperties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( Random.rotation ),
                null );

            m_StaticProperties["rotationUniform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( Random.rotationUniform ),
                null );

            m_StaticProperties["seed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Random.seed ),
                x => Random.seed = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["InitState"] = new BSFunctionReference(
                new BSFunction(
                    "function InitState(seed)",
                    a =>
                    {
                        Random.InitState( WrapperHelper.UnwrapObject < int >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["Range"] = new BSFunctionReference(
                new BSFunction(
                    "function Range(minInclusive, maxInclusive)",
                    a => new BSObject(
                        ( decimal ) Random.Range(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Range"] = new BSFunctionReference(
                new BSFunction(
                    "function Range(minInclusive, maxExclusive)",
                    a => new BSObject(
                        ( decimal ) Random.Range(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["RandomRange"] = new BSFunctionReference(
                new BSFunction(
                    "function RandomRange(min, max)",
                    a => new BSObject(
                        ( decimal ) Random.RandomRange(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["RandomRange"] = new BSFunctionReference(
                new BSFunction(
                    "function RandomRange(min, max)",
                    a => new BSObject(
                        ( decimal ) Random.RandomRange(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ColorHSV"] = new BSFunctionReference(
                new BSFunction(
                    "function ColorHSV()",
                    a => new BSWrapperObject_UnityEngine_Color( Random.ColorHSV() ),
                    0 ) );

            m_StaticProperties["ColorHSV"] = new BSFunctionReference(
                new BSFunction(
                    "function ColorHSV(hueMin, hueMax)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Random.ColorHSV(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ColorHSV"] = new BSFunctionReference(
                new BSFunction(
                    "function ColorHSV(hueMin, hueMax, saturationMin, saturationMax)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Random.ColorHSV(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["ColorHSV"] = new BSFunctionReference(
                new BSFunction(
                    "function ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Random.ColorHSV(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["ColorHSV"] = new BSFunctionReference(
                new BSFunction(
                    "function ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, alphaMin, alphaMax)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Random.ColorHSV(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < float >( a[6] ),
                            WrapperHelper.UnwrapObject < float >( a[7] ) ) ),
                    8 ) );

        }

        #endregion
    }

}

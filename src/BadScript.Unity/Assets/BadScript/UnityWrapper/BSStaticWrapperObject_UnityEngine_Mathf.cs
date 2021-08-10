using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Mathf : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Mathf() : base( typeof( Mathf ) )
        {
            m_StaticProperties["PI"] = new BSReflectionReference( () => new BSObject( ( decimal ) Mathf.PI ), null );

            m_StaticProperties["Deg2Rad"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Mathf.Deg2Rad ),
                null );

            m_StaticProperties["Rad2Deg"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Mathf.Rad2Deg ),
                null );

            m_StaticProperties["Epsilon"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Mathf.Epsilon ),
                null );

            m_StaticProperties["ClosestPowerOfTwo"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPowerOfTwo(value)",
                    a => new BSObject(
                        ( decimal ) Mathf.ClosestPowerOfTwo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsPowerOfTwo"] = new BSFunctionReference(
                new BSFunction(
                    "function IsPowerOfTwo(value)",
                    a => Mathf.IsPowerOfTwo( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["NextPowerOfTwo"] = new BSFunctionReference(
                new BSFunction(
                    "function NextPowerOfTwo(value)",
                    a => new BSObject( ( decimal ) Mathf.NextPowerOfTwo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GammaToLinearSpace"] = new BSFunctionReference(
                new BSFunction(
                    "function GammaToLinearSpace(value)",
                    a => new BSObject(
                        ( decimal ) Mathf.GammaToLinearSpace( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LinearToGammaSpace"] = new BSFunctionReference(
                new BSFunction(
                    "function LinearToGammaSpace(value)",
                    a => new BSObject(
                        ( decimal ) Mathf.LinearToGammaSpace( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CorrelatedColorTemperatureToRGB"] = new BSFunctionReference(
                new BSFunction(
                    "function CorrelatedColorTemperatureToRGB(kelvin)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Mathf.CorrelatedColorTemperatureToRGB( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FloatToHalf"] = new BSFunctionReference(
                new BSFunction(
                    "function FloatToHalf(val)",
                    a => new BSObject( ( decimal ) Mathf.FloatToHalf( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["HalfToFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function HalfToFloat(val)",
                    a => new BSObject( ( decimal ) Mathf.HalfToFloat( WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["PerlinNoise"] = new BSFunctionReference(
                new BSFunction(
                    "function PerlinNoise(x, y)",
                    a => new BSObject(
                        ( decimal ) Mathf.PerlinNoise(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Sin"] = new BSFunctionReference(
                new BSFunction(
                    "function Sin(f)",
                    a => new BSObject( ( decimal ) Mathf.Sin( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Cos"] = new BSFunctionReference(
                new BSFunction(
                    "function Cos(f)",
                    a => new BSObject( ( decimal ) Mathf.Cos( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Tan"] = new BSFunctionReference(
                new BSFunction(
                    "function Tan(f)",
                    a => new BSObject( ( decimal ) Mathf.Tan( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Asin"] = new BSFunctionReference(
                new BSFunction(
                    "function Asin(f)",
                    a => new BSObject( ( decimal ) Mathf.Asin( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Acos"] = new BSFunctionReference(
                new BSFunction(
                    "function Acos(f)",
                    a => new BSObject( ( decimal ) Mathf.Acos( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Atan"] = new BSFunctionReference(
                new BSFunction(
                    "function Atan(f)",
                    a => new BSObject( ( decimal ) Mathf.Atan( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Atan2"] = new BSFunctionReference(
                new BSFunction(
                    "function Atan2(y, x)",
                    a => new BSObject(
                        ( decimal ) Mathf.Atan2(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Sqrt"] = new BSFunctionReference(
                new BSFunction(
                    "function Sqrt(f)",
                    a => new BSObject( ( decimal ) Mathf.Sqrt( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Abs"] = new BSFunctionReference(
                new BSFunction(
                    "function Abs(f)",
                    a => new BSObject( ( decimal ) Mathf.Abs( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Abs"] = new BSFunctionReference(
                new BSFunction(
                    "function Abs(value)",
                    a => new BSObject( ( decimal ) Mathf.Abs( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Min"] = new BSFunctionReference(
                new BSFunction(
                    "function Min(a, b)",
                    a => new BSObject(
                        ( decimal ) Mathf.Min(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Min"] = new BSFunctionReference(
                new BSFunction(
                    "function Min(a, b)",
                    a => new BSObject(
                        ( decimal ) Mathf.Min(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Max"] = new BSFunctionReference(
                new BSFunction(
                    "function Max(a, b)",
                    a => new BSObject(
                        ( decimal ) Mathf.Max(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Max"] = new BSFunctionReference(
                new BSFunction(
                    "function Max(a, b)",
                    a => new BSObject(
                        ( decimal ) Mathf.Max(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Pow"] = new BSFunctionReference(
                new BSFunction(
                    "function Pow(f, p)",
                    a => new BSObject(
                        ( decimal ) Mathf.Pow(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Exp"] = new BSFunctionReference(
                new BSFunction(
                    "function Exp(power)",
                    a => new BSObject( ( decimal ) Mathf.Exp( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Log"] = new BSFunctionReference(
                new BSFunction(
                    "function Log(f, p)",
                    a => new BSObject(
                        ( decimal ) Mathf.Log(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Log"] = new BSFunctionReference(
                new BSFunction(
                    "function Log(f)",
                    a => new BSObject( ( decimal ) Mathf.Log( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Log10"] = new BSFunctionReference(
                new BSFunction(
                    "function Log10(f)",
                    a => new BSObject( ( decimal ) Mathf.Log10( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Ceil"] = new BSFunctionReference(
                new BSFunction(
                    "function Ceil(f)",
                    a => new BSObject( ( decimal ) Mathf.Ceil( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Floor"] = new BSFunctionReference(
                new BSFunction(
                    "function Floor(f)",
                    a => new BSObject( ( decimal ) Mathf.Floor( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Round"] = new BSFunctionReference(
                new BSFunction(
                    "function Round(f)",
                    a => new BSObject( ( decimal ) Mathf.Round( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CeilToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function CeilToInt(f)",
                    a => new BSObject( ( decimal ) Mathf.CeilToInt( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FloorToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function FloorToInt(f)",
                    a => new BSObject( ( decimal ) Mathf.FloorToInt( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["RoundToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function RoundToInt(f)",
                    a => new BSObject( ( decimal ) Mathf.RoundToInt( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Sign"] = new BSFunctionReference(
                new BSFunction(
                    "function Sign(f)",
                    a => new BSObject( ( decimal ) Mathf.Sign( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Clamp"] = new BSFunctionReference(
                new BSFunction(
                    "function Clamp(value, min, max)",
                    a => new BSObject(
                        ( decimal ) Mathf.Clamp(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Clamp"] = new BSFunctionReference(
                new BSFunction(
                    "function Clamp(value, min, max)",
                    a => new BSObject(
                        ( decimal ) Mathf.Clamp(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Clamp01"] = new BSFunctionReference(
                new BSFunction(
                    "function Clamp01(value)",
                    a => new BSObject( ( decimal ) Mathf.Clamp01( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Lerp"] = new BSFunctionReference(
                new BSFunction(
                    "function Lerp(a, b, t)",
                    a => new BSObject(
                        ( decimal ) Mathf.Lerp(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(
                new BSFunction(
                    "function LerpUnclamped(a, b, t)",
                    a => new BSObject(
                        ( decimal ) Mathf.LerpUnclamped(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LerpAngle"] = new BSFunctionReference(
                new BSFunction(
                    "function LerpAngle(a, b, t)",
                    a => new BSObject(
                        ( decimal ) Mathf.LerpAngle(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["MoveTowards"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveTowards(current, target, maxDelta)",
                    a => new BSObject(
                        ( decimal ) Mathf.MoveTowards(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["MoveTowardsAngle"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveTowardsAngle(current, target, maxDelta)",
                    a => new BSObject(
                        ( decimal ) Mathf.MoveTowardsAngle(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["SmoothStep"] = new BSFunctionReference(
                new BSFunction(
                    "function SmoothStep(from, to, t)",
                    a => new BSObject(
                        ( decimal ) Mathf.SmoothStep(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Gamma"] = new BSFunctionReference(
                new BSFunction(
                    "function Gamma(value, absmax, gamma)",
                    a => new BSObject(
                        ( decimal ) Mathf.Gamma(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Approximately"] = new BSFunctionReference(
                new BSFunction(
                    "function Approximately(a, b)",
                    a => Mathf.Approximately(
                        WrapperHelper.UnwrapObject < float >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Repeat"] = new BSFunctionReference(
                new BSFunction(
                    "function Repeat(t, length)",
                    a => new BSObject(
                        ( decimal ) Mathf.Repeat(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["PingPong"] = new BSFunctionReference(
                new BSFunction(
                    "function PingPong(t, length)",
                    a => new BSObject(
                        ( decimal ) Mathf.PingPong(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["InverseLerp"] = new BSFunctionReference(
                new BSFunction(
                    "function InverseLerp(a, b, value)",
                    a => new BSObject(
                        ( decimal ) Mathf.InverseLerp(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["DeltaAngle"] = new BSFunctionReference(
                new BSFunction(
                    "function DeltaAngle(current, target)",
                    a => new BSObject(
                        ( decimal ) Mathf.DeltaAngle(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

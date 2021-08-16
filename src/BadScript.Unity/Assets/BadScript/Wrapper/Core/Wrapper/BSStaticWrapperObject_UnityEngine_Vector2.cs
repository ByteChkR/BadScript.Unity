using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Vector2 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Vector2() : base( typeof( Vector2 ) )
        {
            m_StaticProperties["zero"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Vector2.zero ),
                null );

            m_StaticProperties["one"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Vector2.one ),
                null );

            m_StaticProperties["up"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Vector2.up ),
                null );

            m_StaticProperties["down"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Vector2.down ),
                null );

            m_StaticProperties["left"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Vector2.left ),
                null );

            m_StaticProperties["right"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Vector2.right ),
                null );

            m_StaticProperties["positiveInfinity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Vector2.positiveInfinity ),
                null );

            m_StaticProperties["negativeInfinity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Vector2.negativeInfinity ),
                null );

            m_StaticProperties["kEpsilon"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vector2.kEpsilon ),
                null );

            m_StaticProperties["kEpsilonNormalSqrt"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vector2.kEpsilonNormalSqrt ),
                null );

            m_StaticProperties["Lerp"] = new BSFunctionReference(
                new BSFunction(
                    "function Lerp(a, b, t)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.Lerp(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(
                new BSFunction(
                    "function LerpUnclamped(a, b, t)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.LerpUnclamped(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["MoveTowards"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveTowards(current, target, maxDistanceDelta)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.MoveTowards(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Scale"] = new BSFunctionReference(
                new BSFunction(
                    "function Scale(a, b)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.Scale(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Reflect"] = new BSFunctionReference(
                new BSFunction(
                    "function Reflect(inDirection, inNormal)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.Reflect(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Perpendicular"] = new BSFunctionReference(
                new BSFunction(
                    "function Perpendicular(inDirection)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.Perpendicular( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Dot"] = new BSFunctionReference(
                new BSFunction(
                    "function Dot(lhs, rhs)",
                    a => new BSObject(
                        ( decimal ) Vector2.Dot(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Angle"] = new BSFunctionReference(
                new BSFunction(
                    "function Angle(from, to)",
                    a => new BSObject(
                        ( decimal ) Vector2.Angle(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["SignedAngle"] = new BSFunctionReference(
                new BSFunction(
                    "function SignedAngle(from, to)",
                    a => new BSObject(
                        ( decimal ) Vector2.SignedAngle(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Distance"] = new BSFunctionReference(
                new BSFunction(
                    "function Distance(a, b)",
                    a => new BSObject(
                        ( decimal ) Vector2.Distance(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ClampMagnitude"] = new BSFunctionReference(
                new BSFunction(
                    "function ClampMagnitude(vector, maxLength)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.ClampMagnitude(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["SqrMagnitude"] = new BSFunctionReference(
                new BSFunction(
                    "function SqrMagnitude(a)",
                    a => new BSObject(
                        ( decimal ) Vector2.SqrMagnitude( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Min"] = new BSFunctionReference(
                new BSFunction(
                    "function Min(lhs, rhs)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.Min(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Max"] = new BSFunctionReference(
                new BSFunction(
                    "function Max(lhs, rhs)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Vector2.Max(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

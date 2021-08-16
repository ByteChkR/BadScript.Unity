using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Vector4 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Vector4() : base( typeof( Vector4 ) )
        {
            m_StaticProperties["zero"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( Vector4.zero ),
                null );

            m_StaticProperties["one"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( Vector4.one ),
                null );

            m_StaticProperties["positiveInfinity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( Vector4.positiveInfinity ),
                null );

            m_StaticProperties["negativeInfinity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( Vector4.negativeInfinity ),
                null );

            m_StaticProperties["kEpsilon"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vector4.kEpsilon ),
                null );

            m_StaticProperties["Lerp"] = new BSFunctionReference(
                new BSFunction(
                    "function Lerp(a, b, t)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Vector4.Lerp(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(
                new BSFunction(
                    "function LerpUnclamped(a, b, t)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Vector4.LerpUnclamped(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["MoveTowards"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveTowards(current, target, maxDistanceDelta)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Vector4.MoveTowards(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Scale"] = new BSFunctionReference(
                new BSFunction(
                    "function Scale(a, b)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Vector4.Scale(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Normalize"] = new BSFunctionReference(
                new BSFunction(
                    "function Normalize(a)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Vector4.Normalize( WrapperHelper.UnwrapObject < Vector4 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Dot"] = new BSFunctionReference(
                new BSFunction(
                    "function Dot(a, b)",
                    a => new BSObject(
                        ( decimal ) Vector4.Dot(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Project"] = new BSFunctionReference(
                new BSFunction(
                    "function Project(a, b)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Vector4.Project(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Distance"] = new BSFunctionReference(
                new BSFunction(
                    "function Distance(a, b)",
                    a => new BSObject(
                        ( decimal ) Vector4.Distance(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Magnitude"] = new BSFunctionReference(
                new BSFunction(
                    "function Magnitude(a)",
                    a => new BSObject(
                        ( decimal ) Vector4.Magnitude( WrapperHelper.UnwrapObject < Vector4 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Min"] = new BSFunctionReference(
                new BSFunction(
                    "function Min(lhs, rhs)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Vector4.Min(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Max"] = new BSFunctionReference(
                new BSFunction(
                    "function Max(lhs, rhs)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Vector4.Max(
                            WrapperHelper.UnwrapObject < Vector4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["SqrMagnitude"] = new BSFunctionReference(
                new BSFunction(
                    "function SqrMagnitude(a)",
                    a => new BSObject(
                        ( decimal ) Vector4.SqrMagnitude( WrapperHelper.UnwrapObject < Vector4 >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

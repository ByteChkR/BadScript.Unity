using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Vector2Int : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Vector2Int() : base( typeof( Vector2Int ) )
        {
            m_StaticProperties["zero"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2Int( Vector2Int.zero ),
                null );

            m_StaticProperties["one"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2Int( Vector2Int.one ),
                null );

            m_StaticProperties["up"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2Int( Vector2Int.up ),
                null );

            m_StaticProperties["down"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2Int( Vector2Int.down ),
                null );

            m_StaticProperties["left"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2Int( Vector2Int.left ),
                null );

            m_StaticProperties["right"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2Int( Vector2Int.right ),
                null );

            m_StaticProperties["Distance"] = new BSFunctionReference(
                new BSFunction(
                    "function Distance(a, b)",
                    a => new BSObject(
                        ( decimal ) Vector2Int.Distance(
                            WrapperHelper.UnwrapObject < Vector2Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2Int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Min"] = new BSFunctionReference(
                new BSFunction(
                    "function Min(lhs, rhs)",
                    a => new BSWrapperObject_UnityEngine_Vector2Int(
                        Vector2Int.Min(
                            WrapperHelper.UnwrapObject < Vector2Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2Int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Max"] = new BSFunctionReference(
                new BSFunction(
                    "function Max(lhs, rhs)",
                    a => new BSWrapperObject_UnityEngine_Vector2Int(
                        Vector2Int.Max(
                            WrapperHelper.UnwrapObject < Vector2Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2Int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Scale"] = new BSFunctionReference(
                new BSFunction(
                    "function Scale(a, b)",
                    a => new BSWrapperObject_UnityEngine_Vector2Int(
                        Vector2Int.Scale(
                            WrapperHelper.UnwrapObject < Vector2Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2Int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["FloorToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function FloorToInt(v)",
                    a => new BSWrapperObject_UnityEngine_Vector2Int(
                        Vector2Int.FloorToInt( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CeilToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function CeilToInt(v)",
                    a => new BSWrapperObject_UnityEngine_Vector2Int(
                        Vector2Int.CeilToInt( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["RoundToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function RoundToInt(v)",
                    a => new BSWrapperObject_UnityEngine_Vector2Int(
                        Vector2Int.RoundToInt( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

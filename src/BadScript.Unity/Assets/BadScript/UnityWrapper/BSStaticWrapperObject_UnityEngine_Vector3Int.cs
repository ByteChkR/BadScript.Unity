using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Vector3Int : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Vector3Int() : base( typeof( Vector3Int ) )
        {
            m_StaticProperties["zero"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( Vector3Int.zero ),
                null );

            m_StaticProperties["one"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( Vector3Int.one ),
                null );

            m_StaticProperties["up"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( Vector3Int.up ),
                null );

            m_StaticProperties["down"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( Vector3Int.down ),
                null );

            m_StaticProperties["left"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( Vector3Int.left ),
                null );

            m_StaticProperties["right"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( Vector3Int.right ),
                null );

            m_StaticProperties["forward"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( Vector3Int.forward ),
                null );

            m_StaticProperties["back"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( Vector3Int.back ),
                null );

            m_StaticProperties["Distance"] = new BSFunctionReference(
                new BSFunction(
                    "function Distance(a, b)",
                    a => new BSObject(
                        ( decimal ) Vector3Int.Distance(
                            WrapperHelper.UnwrapObject < Vector3Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3Int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Min"] = new BSFunctionReference(
                new BSFunction(
                    "function Min(lhs, rhs)",
                    a => new BSWrapperObject_UnityEngine_Vector3Int(
                        Vector3Int.Min(
                            WrapperHelper.UnwrapObject < Vector3Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3Int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Max"] = new BSFunctionReference(
                new BSFunction(
                    "function Max(lhs, rhs)",
                    a => new BSWrapperObject_UnityEngine_Vector3Int(
                        Vector3Int.Max(
                            WrapperHelper.UnwrapObject < Vector3Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3Int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Scale"] = new BSFunctionReference(
                new BSFunction(
                    "function Scale(a, b)",
                    a => new BSWrapperObject_UnityEngine_Vector3Int(
                        Vector3Int.Scale(
                            WrapperHelper.UnwrapObject < Vector3Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3Int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["FloorToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function FloorToInt(v)",
                    a => new BSWrapperObject_UnityEngine_Vector3Int(
                        Vector3Int.FloorToInt( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CeilToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function CeilToInt(v)",
                    a => new BSWrapperObject_UnityEngine_Vector3Int(
                        Vector3Int.CeilToInt( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["RoundToInt"] = new BSFunctionReference(
                new BSFunction(
                    "function RoundToInt(v)",
                    a => new BSWrapperObject_UnityEngine_Vector3Int(
                        Vector3Int.RoundToInt( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

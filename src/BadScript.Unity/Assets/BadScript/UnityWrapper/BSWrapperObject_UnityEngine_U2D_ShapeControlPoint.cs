using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.U2D;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_U2D_ShapeControlPoint : BSWrapperObject < ShapeControlPoint >

    {
        #region Public

        public BSWrapperObject_UnityEngine_U2D_ShapeControlPoint( ShapeControlPoint obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["leftTangent"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.leftTangent ),
                x => m_InternalObject.leftTangent = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rightTangent"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.rightTangent ),
                x => m_InternalObject.rightTangent = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["mode"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mode ),
                x => m_InternalObject.mode = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

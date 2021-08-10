using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ColliderDistance2D : BSWrapperObject < ColliderDistance2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ColliderDistance2D( ColliderDistance2D obj ) : base( obj )
        {
            m_Properties["pointA"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.pointA ),
                x => m_InternalObject.pointA = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["pointB"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.pointB ),
                x => m_InternalObject.pointB = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.normal ),
                null );

            m_Properties["distance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distance ),
                x => m_InternalObject.distance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["isOverlapped"] = new BSReflectionReference(
                () => m_InternalObject.isOverlapped ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isValid = WrapperHelper.UnwrapObject < bool >( x ) );

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

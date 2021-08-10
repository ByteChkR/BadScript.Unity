using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WheelHit : BSWrapperObject < WheelHit >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WheelHit( WheelHit obj ) : base( obj )
        {
            m_Properties["collider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Collider( m_InternalObject.collider ),
                x => m_InternalObject.collider = WrapperHelper.UnwrapObject < Collider >( x ) );

            m_Properties["point"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.point ),
                x => m_InternalObject.point = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.normal ),
                x => m_InternalObject.normal = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["forwardDir"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.forwardDir ),
                x => m_InternalObject.forwardDir = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["sidewaysDir"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.sidewaysDir ),
                x => m_InternalObject.sidewaysDir = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["force"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.force ),
                x => m_InternalObject.force = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["forwardSlip"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.forwardSlip ),
                x => m_InternalObject.forwardSlip = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["sidewaysSlip"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sidewaysSlip ),
                x => m_InternalObject.sidewaysSlip = WrapperHelper.UnwrapObject < float >( x ) );

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

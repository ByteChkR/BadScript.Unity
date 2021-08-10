using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CapsulecastCommand : BSWrapperObject < CapsulecastCommand >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CapsulecastCommand( CapsulecastCommand obj ) : base( obj )
        {
            m_Properties["point1"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.point1 ),
                x => m_InternalObject.point1 = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["point2"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.point2 ),
                x => m_InternalObject.point2 = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["radius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.radius ),
                x => m_InternalObject.radius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["direction"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.direction ),
                x => m_InternalObject.direction = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["distance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distance ),
                x => m_InternalObject.distance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["layerMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layerMask ),
                x => m_InternalObject.layerMask = WrapperHelper.UnwrapObject < int >( x ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_BoxcastCommand : BSWrapperObject < BoxcastCommand >

    {
        #region Public

        public BSWrapperObject_UnityEngine_BoxcastCommand( BoxcastCommand obj ) : base( obj )
        {
            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["halfExtents"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.halfExtents ),
                x => m_InternalObject.halfExtents = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["orientation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.orientation ),
                x => m_InternalObject.orientation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

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

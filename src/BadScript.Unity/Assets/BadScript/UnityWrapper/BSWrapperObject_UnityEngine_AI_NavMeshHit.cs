using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshHit : BSWrapperObject < NavMeshHit >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshHit( NavMeshHit obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.normal ),
                x => m_InternalObject.normal = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["distance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distance ),
                x => m_InternalObject.distance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["mask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mask ),
                x => m_InternalObject.mask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["hit"] = new BSReflectionReference(
                () => m_InternalObject.hit ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.hit = WrapperHelper.UnwrapObject < bool >( x ) );

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

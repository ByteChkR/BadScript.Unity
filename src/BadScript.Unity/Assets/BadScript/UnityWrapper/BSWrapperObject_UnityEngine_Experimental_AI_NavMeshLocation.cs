using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Experimental.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Experimental_AI_NavMeshLocation : BSWrapperObject < NavMeshLocation >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_AI_NavMeshLocation( NavMeshLocation obj ) : base( obj )
        {
            m_Properties["polygon"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Experimental_AI_PolygonId( m_InternalObject.polygon ),
                null );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                null );

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

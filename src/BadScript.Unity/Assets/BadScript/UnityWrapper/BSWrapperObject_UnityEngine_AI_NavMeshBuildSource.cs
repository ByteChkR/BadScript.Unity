using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshBuildSource : BSWrapperObject < NavMeshBuildSource >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshBuildSource( NavMeshBuildSource obj ) : base( obj )
        {
            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.transform ),
                x => m_InternalObject.transform = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["area"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.area ),
                x => m_InternalObject.area = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sourceObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Object( m_InternalObject.sourceObject ),
                x => m_InternalObject.sourceObject = WrapperHelper.UnwrapObject < Object >( x ) );

            m_Properties["component"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Component( m_InternalObject.component ),
                x => m_InternalObject.component = WrapperHelper.UnwrapObject < Component >( x ) );

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

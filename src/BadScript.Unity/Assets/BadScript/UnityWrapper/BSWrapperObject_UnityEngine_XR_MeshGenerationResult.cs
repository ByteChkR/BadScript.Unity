using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_XR_MeshGenerationResult : BSWrapperObject < MeshGenerationResult >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_MeshGenerationResult( MeshGenerationResult obj ) : base( obj )
        {
            m_Properties["MeshId"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_XR_MeshId( m_InternalObject.MeshId ),
                null );

            m_Properties["Mesh"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Mesh( m_InternalObject.Mesh ),
                null );

            m_Properties["MeshCollider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_MeshCollider( m_InternalObject.MeshCollider ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < MeshGenerationResult >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_XR_MeshInfo : BSWrapperObject < MeshInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_MeshInfo( MeshInfo obj ) : base( obj )
        {
            m_Properties["MeshId"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_XR_MeshId( m_InternalObject.MeshId ),
                x => m_InternalObject.MeshId = WrapperHelper.UnwrapObject < MeshId >( x ) );

            m_Properties["PriorityHint"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.PriorityHint ),
                x => m_InternalObject.PriorityHint = WrapperHelper.UnwrapObject < int >( x ) );

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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < MeshInfo >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

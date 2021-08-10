using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshQueryFilter : BSWrapperObject < NavMeshQueryFilter >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshQueryFilter( NavMeshQueryFilter obj ) : base( obj )
        {
            m_Properties["areaMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.areaMask ),
                x => m_InternalObject.areaMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["agentTypeID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.agentTypeID ),
                x => m_InternalObject.agentTypeID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["GetAreaCost"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAreaCost(areaIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetAreaCost( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshLinkData : BSWrapperObject < NavMeshLinkData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshLinkData( NavMeshLinkData obj ) : base( obj )
        {
            m_Properties["startPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.startPosition ),
                x => m_InternalObject.startPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["endPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.endPosition ),
                x => m_InternalObject.endPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["costModifier"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.costModifier ),
                x => m_InternalObject.costModifier = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bidirectional"] = new BSReflectionReference(
                () => m_InternalObject.bidirectional ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bidirectional = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["area"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.area ),
                x => m_InternalObject.area = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["agentTypeID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.agentTypeID ),
                x => m_InternalObject.agentTypeID = WrapperHelper.UnwrapObject < int >( x ) );

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

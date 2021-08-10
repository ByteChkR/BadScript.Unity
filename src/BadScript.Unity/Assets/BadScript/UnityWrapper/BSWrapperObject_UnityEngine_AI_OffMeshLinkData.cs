using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_OffMeshLinkData : BSWrapperObject < OffMeshLinkData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_OffMeshLinkData( OffMeshLinkData obj ) : base( obj )
        {
            m_Properties["valid"] = new BSReflectionReference(
                () => m_InternalObject.valid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["activated"] = new BSReflectionReference(
                () => m_InternalObject.activated ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["startPos"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.startPos ),
                null );

            m_Properties["endPos"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.endPos ),
                null );

            m_Properties["offMeshLink"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AI_OffMeshLink( m_InternalObject.offMeshLink ),
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

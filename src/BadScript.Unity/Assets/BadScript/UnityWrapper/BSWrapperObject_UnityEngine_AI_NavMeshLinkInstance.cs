using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshLinkInstance : BSWrapperObject < NavMeshLinkInstance >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshLinkInstance( NavMeshLinkInstance obj ) : base( obj )
        {
            m_Properties["valid"] = new BSReflectionReference(
                () => m_InternalObject.valid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["owner"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Object( m_InternalObject.owner ),
                x => m_InternalObject.owner = WrapperHelper.UnwrapObject < Object >( x ) );

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

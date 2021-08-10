using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshBuildMarkup : BSWrapperObject < NavMeshBuildMarkup >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshBuildMarkup( NavMeshBuildMarkup obj ) : base( obj )
        {
            m_Properties["overrideArea"] = new BSReflectionReference(
                () => m_InternalObject.overrideArea ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overrideArea = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["area"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.area ),
                x => m_InternalObject.area = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["ignoreFromBuild"] = new BSReflectionReference(
                () => m_InternalObject.ignoreFromBuild ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.ignoreFromBuild = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["root"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.root ),
                x => m_InternalObject.root = WrapperHelper.UnwrapObject < Transform >( x ) );

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

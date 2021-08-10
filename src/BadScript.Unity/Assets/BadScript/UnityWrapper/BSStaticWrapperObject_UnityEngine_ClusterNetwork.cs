using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ClusterNetwork : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ClusterNetwork() : base( typeof( ClusterNetwork ) )
        {
            m_StaticProperties["isMasterOfCluster"] = new BSReflectionReference(
                () => ClusterNetwork.isMasterOfCluster ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isDisconnected"] = new BSReflectionReference(
                () => ClusterNetwork.isDisconnected ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["nodeIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ClusterNetwork.nodeIndex ),
                x => ClusterNetwork.nodeIndex = WrapperHelper.UnwrapObject < int >( x ) );

        }

        #endregion
    }

}

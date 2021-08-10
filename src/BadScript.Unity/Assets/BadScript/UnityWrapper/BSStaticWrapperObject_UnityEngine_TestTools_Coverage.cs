using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TestTools;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_TestTools_Coverage : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_TestTools_Coverage() : base( typeof( Coverage ) )
        {
            m_StaticProperties["enabled"] = new BSReflectionReference(
                () => Coverage.enabled ? BSObject.One : BSObject.Zero,
                x => Coverage.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["GetStatsFor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStatsFor(method)",
                    a => new BSWrapperObject_UnityEngine_TestTools_CoveredMethodStats(
                        Coverage.GetStatsFor( WrapperHelper.UnwrapObject < MethodBase >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

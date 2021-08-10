using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Assertions;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Assertions_Assert : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Assertions_Assert() : base( typeof( Assert ) )
        {
            m_StaticProperties["raiseExceptions"] = new BSReflectionReference(
                () => Assert.raiseExceptions ? BSObject.One : BSObject.Zero,
                x => Assert.raiseExceptions = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}

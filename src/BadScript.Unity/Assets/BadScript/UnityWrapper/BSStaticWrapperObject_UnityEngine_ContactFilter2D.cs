using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ContactFilter2D : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ContactFilter2D() : base( typeof( ContactFilter2D ) )
        {
            m_StaticProperties["NormalAngleUpperLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ContactFilter2D.NormalAngleUpperLimit ),
                null );

        }

        #endregion
    }

}

using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_ILayoutIgnorer : BSWrapperObject < ILayoutIgnorer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_ILayoutIgnorer( ILayoutIgnorer obj ) : base( obj )
        {
            m_Properties["ignoreLayout"] = new BSReflectionReference(
                () => m_InternalObject.ignoreLayout ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

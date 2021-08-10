using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_IClippable : BSWrapperObject < IClippable >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_IClippable( IClippable obj ) : base( obj )
        {
            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["rectTransform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectTransform( m_InternalObject.rectTransform ),
                null );

        }

        #endregion
    }

}

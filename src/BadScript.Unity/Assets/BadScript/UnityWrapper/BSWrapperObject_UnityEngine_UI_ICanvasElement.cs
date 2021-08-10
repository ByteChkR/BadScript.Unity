using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_ICanvasElement : BSWrapperObject < ICanvasElement >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_ICanvasElement( ICanvasElement obj ) : base( obj )
        {
            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

        }

        #endregion
    }

}

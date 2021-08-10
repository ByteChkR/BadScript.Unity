using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_GUIStyle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_GUIStyle() : base( typeof( GUIStyle ) )
        {
            m_StaticProperties["none"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( GUIStyle.none ),
                null );

        }

        #endregion
    }

}

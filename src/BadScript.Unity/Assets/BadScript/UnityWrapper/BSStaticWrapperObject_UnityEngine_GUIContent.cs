using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_GUIContent : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_GUIContent() : base( typeof( GUIContent ) )
        {
            m_StaticProperties["none"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIContent( GUIContent.none ),
                x => GUIContent.none = WrapperHelper.UnwrapObject < GUIContent >( x ) );

        }

        #endregion
    }

}

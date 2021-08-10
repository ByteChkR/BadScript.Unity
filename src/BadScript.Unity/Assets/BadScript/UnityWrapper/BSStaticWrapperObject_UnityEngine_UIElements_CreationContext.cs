using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_CreationContext : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_CreationContext() : base( typeof( CreationContext ) )
        {
            m_StaticProperties["Default"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_CreationContext( CreationContext.Default ),
                null );

        }

        #endregion
    }

}

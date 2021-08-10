using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Foldout : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Foldout() : base( typeof( Foldout ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( Foldout.ussClassName ),
                null );

            m_StaticProperties["toggleUssClassName"] = new BSReflectionReference(
                () => new BSObject( Foldout.toggleUssClassName ),
                null );

            m_StaticProperties["contentUssClassName"] = new BSReflectionReference(
                () => new BSObject( Foldout.contentUssClassName ),
                null );

        }

        #endregion
    }

}

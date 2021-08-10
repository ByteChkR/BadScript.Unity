using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_HelpBox : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_HelpBox() : base( typeof( HelpBox ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( HelpBox.ussClassName ),
                null );

            m_StaticProperties["labelUssClassName"] = new BSReflectionReference(
                () => new BSObject( HelpBox.labelUssClassName ),
                null );

            m_StaticProperties["iconUssClassName"] = new BSReflectionReference(
                () => new BSObject( HelpBox.iconUssClassName ),
                null );

            m_StaticProperties["iconInfoUssClassName"] = new BSReflectionReference(
                () => new BSObject( HelpBox.iconInfoUssClassName ),
                null );

            m_StaticProperties["iconwarningUssClassName"] = new BSReflectionReference(
                () => new BSObject( HelpBox.iconwarningUssClassName ),
                null );

            m_StaticProperties["iconErrorUssClassName"] = new BSReflectionReference(
                () => new BSObject( HelpBox.iconErrorUssClassName ),
                null );

        }

        #endregion
    }

}

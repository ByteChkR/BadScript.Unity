using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Toggle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Toggle() : base( typeof( Toggle ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( Toggle.ussClassName ),
                null );

            m_StaticProperties["labelUssClassName"] = new BSReflectionReference(
                () => new BSObject( Toggle.labelUssClassName ),
                null );

            m_StaticProperties["inputUssClassName"] = new BSReflectionReference(
                () => new BSObject( Toggle.inputUssClassName ),
                null );

            m_StaticProperties["noTextVariantUssClassName"] = new BSReflectionReference(
                () => new BSObject( Toggle.noTextVariantUssClassName ),
                null );

            m_StaticProperties["checkmarkUssClassName"] = new BSReflectionReference(
                () => new BSObject( Toggle.checkmarkUssClassName ),
                null );

            m_StaticProperties["textUssClassName"] = new BSReflectionReference(
                () => new BSObject( Toggle.textUssClassName ),
                null );

        }

        #endregion
    }

}

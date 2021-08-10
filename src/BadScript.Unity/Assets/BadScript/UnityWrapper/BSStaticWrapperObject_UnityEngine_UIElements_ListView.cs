using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_ListView : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_ListView() : base( typeof( ListView ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( ListView.ussClassName ),
                null );

            m_StaticProperties["borderUssClassName"] = new BSReflectionReference(
                () => new BSObject( ListView.borderUssClassName ),
                null );

            m_StaticProperties["itemUssClassName"] = new BSReflectionReference(
                () => new BSObject( ListView.itemUssClassName ),
                null );

            m_StaticProperties["dragHoverBarUssClassName"] = new BSReflectionReference(
                () => new BSObject( ListView.dragHoverBarUssClassName ),
                null );

            m_StaticProperties["itemDragHoverUssClassName"] = new BSReflectionReference(
                () => new BSObject( ListView.itemDragHoverUssClassName ),
                null );

            m_StaticProperties["itemSelectedVariantUssClassName"] = new BSReflectionReference(
                () => new BSObject( ListView.itemSelectedVariantUssClassName ),
                null );

            m_StaticProperties["itemAlternativeBackgroundUssClassName"] = new BSReflectionReference(
                () => new BSObject( ListView.itemAlternativeBackgroundUssClassName ),
                null );

        }

        #endregion
    }

}

using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_ScrollView : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_ScrollView() : base( typeof( ScrollView ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.ussClassName ),
                null );

            m_StaticProperties["viewportUssClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.viewportUssClassName ),
                null );

            m_StaticProperties["contentUssClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.contentUssClassName ),
                null );

            m_StaticProperties["hScrollerUssClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.hScrollerUssClassName ),
                null );

            m_StaticProperties["vScrollerUssClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.vScrollerUssClassName ),
                null );

            m_StaticProperties["horizontalVariantUssClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.horizontalVariantUssClassName ),
                null );

            m_StaticProperties["verticalVariantUssClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.verticalVariantUssClassName ),
                null );

            m_StaticProperties["verticalHorizontalVariantUssClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.verticalHorizontalVariantUssClassName ),
                null );

            m_StaticProperties["scrollVariantUssClassName"] = new BSReflectionReference(
                () => new BSObject( ScrollView.scrollVariantUssClassName ),
                null );

        }

        #endregion
    }

}

using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Scroller : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Scroller() : base( typeof( Scroller ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( Scroller.ussClassName ),
                null );

            m_StaticProperties["horizontalVariantUssClassName"] = new BSReflectionReference(
                () => new BSObject( Scroller.horizontalVariantUssClassName ),
                null );

            m_StaticProperties["verticalVariantUssClassName"] = new BSReflectionReference(
                () => new BSObject( Scroller.verticalVariantUssClassName ),
                null );

            m_StaticProperties["sliderUssClassName"] = new BSReflectionReference(
                () => new BSObject( Scroller.sliderUssClassName ),
                null );

            m_StaticProperties["lowButtonUssClassName"] = new BSReflectionReference(
                () => new BSObject( Scroller.lowButtonUssClassName ),
                null );

            m_StaticProperties["highButtonUssClassName"] = new BSReflectionReference(
                () => new BSObject( Scroller.highButtonUssClassName ),
                null );

        }

        #endregion
    }

}

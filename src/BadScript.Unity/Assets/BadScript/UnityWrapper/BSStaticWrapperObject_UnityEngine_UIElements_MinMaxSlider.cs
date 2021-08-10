using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_MinMaxSlider : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_MinMaxSlider() : base( typeof( MinMaxSlider ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( MinMaxSlider.ussClassName ),
                null );

            m_StaticProperties["labelUssClassName"] = new BSReflectionReference(
                () => new BSObject( MinMaxSlider.labelUssClassName ),
                null );

            m_StaticProperties["inputUssClassName"] = new BSReflectionReference(
                () => new BSObject( MinMaxSlider.inputUssClassName ),
                null );

            m_StaticProperties["trackerUssClassName"] = new BSReflectionReference(
                () => new BSObject( MinMaxSlider.trackerUssClassName ),
                null );

            m_StaticProperties["draggerUssClassName"] = new BSReflectionReference(
                () => new BSObject( MinMaxSlider.draggerUssClassName ),
                null );

            m_StaticProperties["minThumbUssClassName"] = new BSReflectionReference(
                () => new BSObject( MinMaxSlider.minThumbUssClassName ),
                null );

            m_StaticProperties["maxThumbUssClassName"] = new BSReflectionReference(
                () => new BSObject( MinMaxSlider.maxThumbUssClassName ),
                null );

        }

        #endregion
    }

}

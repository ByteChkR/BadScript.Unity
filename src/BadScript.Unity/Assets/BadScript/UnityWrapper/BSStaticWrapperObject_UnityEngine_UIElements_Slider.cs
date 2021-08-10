using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Slider : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Slider() : base( typeof( Slider ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( Slider.ussClassName ),
                null );

            m_StaticProperties["labelUssClassName"] = new BSReflectionReference(
                () => new BSObject( Slider.labelUssClassName ),
                null );

            m_StaticProperties["inputUssClassName"] = new BSReflectionReference(
                () => new BSObject( Slider.inputUssClassName ),
                null );

        }

        #endregion
    }

}

using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_SliderInt : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_SliderInt() : base( typeof( SliderInt ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( SliderInt.ussClassName ),
                null );

            m_StaticProperties["labelUssClassName"] = new BSReflectionReference(
                () => new BSObject( SliderInt.labelUssClassName ),
                null );

            m_StaticProperties["inputUssClassName"] = new BSReflectionReference(
                () => new BSObject( SliderInt.inputUssClassName ),
                null );

        }

        #endregion
    }

}

using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_IManipulator : BSWrapperObject < IManipulator >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IManipulator( IManipulator obj ) : base( obj )
        {
            m_Properties["target"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VisualElement( m_InternalObject.target ),
                x => m_InternalObject.target = WrapperHelper.UnwrapObject < VisualElement >( x ) );

        }

        #endregion
    }

}

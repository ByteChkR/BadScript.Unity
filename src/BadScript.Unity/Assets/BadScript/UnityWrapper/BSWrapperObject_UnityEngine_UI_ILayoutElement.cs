using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_ILayoutElement : BSWrapperObject < ILayoutElement >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_ILayoutElement( ILayoutElement obj ) : base( obj )
        {
            m_Properties["minWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minWidth ),
                null );

            m_Properties["preferredWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.preferredWidth ),
                null );

            m_Properties["flexibleWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.flexibleWidth ),
                null );

            m_Properties["minHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minHeight ),
                null );

            m_Properties["preferredHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.preferredHeight ),
                null );

            m_Properties["flexibleHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.flexibleHeight ),
                null );

            m_Properties["layoutPriority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layoutPriority ),
                null );

        }

        #endregion
    }

}

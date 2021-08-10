using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_PointerType : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_PointerType() : base( typeof( PointerType ) )
        {
            m_StaticProperties["mouse"] = new BSReflectionReference( () => new BSObject( PointerType.mouse ), null );
            m_StaticProperties["touch"] = new BSReflectionReference( () => new BSObject( PointerType.touch ), null );
            m_StaticProperties["pen"] = new BSReflectionReference( () => new BSObject( PointerType.pen ), null );

            m_StaticProperties["unknown"] = new BSReflectionReference(
                () => new BSObject( PointerType.unknown ),
                null );

        }

        #endregion
    }

}

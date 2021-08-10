using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.EventSystems;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_EventSystems_PointerInputModule : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_EventSystems_PointerInputModule() : base(
            typeof( PointerInputModule ) )
        {
            m_StaticProperties["kMouseLeftId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerInputModule.kMouseLeftId ),
                null );

            m_StaticProperties["kMouseRightId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerInputModule.kMouseRightId ),
                null );

            m_StaticProperties["kMouseMiddleId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerInputModule.kMouseMiddleId ),
                null );

            m_StaticProperties["kFakeTouchesId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerInputModule.kFakeTouchesId ),
                null );

        }

        #endregion
    }

}

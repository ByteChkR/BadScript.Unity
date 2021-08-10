using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.EventSystems;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_EventSystems_EventSystem : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_EventSystems_EventSystem() : base( typeof( EventSystem ) )
        {
            m_StaticProperties["current"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_EventSystems_EventSystem( EventSystem.current ),
                x => EventSystem.current = WrapperHelper.UnwrapObject < EventSystem >( x ) );

        }

        #endregion
    }

}

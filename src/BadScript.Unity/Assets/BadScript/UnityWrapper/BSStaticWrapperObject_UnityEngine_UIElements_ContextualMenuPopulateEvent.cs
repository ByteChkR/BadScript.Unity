using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_ContextualMenuPopulateEvent : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_ContextualMenuPopulateEvent() : base(
            typeof( ContextualMenuPopulateEvent ) )
        {
            m_StaticProperties["GetPooled"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPooled(triggerEvent, menu, target, menuManager)",
                    a => new BSWrapperObject_UnityEngine_UIElements_ContextualMenuPopulateEvent(
                        ContextualMenuPopulateEvent.GetPooled(
                            WrapperHelper.UnwrapObject < EventBase >( a[0] ),
                            WrapperHelper.UnwrapObject < DropdownMenu >( a[1] ),
                            WrapperHelper.UnwrapObject < IEventHandler >( a[2] ),
                            WrapperHelper.UnwrapObject < ContextualMenuManager >( a[3] ) ) ),
                    4 ) );

        }

        #endregion
    }

}

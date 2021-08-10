using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_MouseLeaveWindowEvent : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_MouseLeaveWindowEvent() : base(
            typeof( MouseLeaveWindowEvent ) )
        {
            m_StaticProperties["GetPooled"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPooled(systemEvent)",
                    a => new BSWrapperObject_UnityEngine_UIElements_MouseLeaveWindowEvent(
                        MouseLeaveWindowEvent.GetPooled( WrapperHelper.UnwrapObject < Event >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
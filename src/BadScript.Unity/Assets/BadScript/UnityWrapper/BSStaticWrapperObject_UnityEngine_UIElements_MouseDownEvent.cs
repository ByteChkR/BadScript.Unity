using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_MouseDownEvent : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_MouseDownEvent() : base( typeof( MouseDownEvent ) )
        {
            m_StaticProperties["GetPooled"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPooled(systemEvent)",
                    a => new BSWrapperObject_UnityEngine_UIElements_MouseDownEvent(
                        MouseDownEvent.GetPooled( WrapperHelper.UnwrapObject < Event >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_InputEvent : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_InputEvent() : base( typeof( InputEvent ) )
        {
            m_StaticProperties["GetPooled"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPooled(previousData, newData)",
                    a => new BSWrapperObject_UnityEngine_UIElements_InputEvent(
                        InputEvent.GetPooled(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

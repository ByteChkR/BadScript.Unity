using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_IFocusRing : BSWrapperObject < IFocusRing >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IFocusRing( IFocusRing obj ) : base( obj )
        {
            m_Properties["GetFocusChangeDirection"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFocusChangeDirection(currentFocusable, e)",
                    a => new BSWrapperObject_UnityEngine_UIElements_FocusChangeDirection(
                        m_InternalObject.GetFocusChangeDirection(
                            WrapperHelper.UnwrapObject < Focusable >( a[0] ),
                            WrapperHelper.UnwrapObject < EventBase >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetNextFocusable"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNextFocusable(currentFocusable, direction)",
                    a => new BSWrapperObject_UnityEngine_UIElements_Focusable(
                        m_InternalObject.GetNextFocusable(
                            WrapperHelper.UnwrapObject < Focusable >( a[0] ),
                            WrapperHelper.UnwrapObject < FocusChangeDirection >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

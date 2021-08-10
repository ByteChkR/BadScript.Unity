using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_VisualElementFocusRing : BSWrapperObject < VisualElementFocusRing >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_VisualElementFocusRing( VisualElementFocusRing obj ) : base( obj )
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

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_GeometryChangedEvent : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_GeometryChangedEvent() : base(
            typeof( GeometryChangedEvent ) )
        {
            m_StaticProperties["GetPooled"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPooled(oldRect, newRect)",
                    a => new BSWrapperObject_UnityEngine_UIElements_GeometryChangedEvent(
                        GeometryChangedEvent.GetPooled(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UI_MaskUtilities : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_MaskUtilities() : base( typeof( MaskUtilities ) )
        {
            m_StaticProperties["FindRootSortOverrideCanvas"] = new BSFunctionReference(
                new BSFunction(
                    "function FindRootSortOverrideCanvas(start)",
                    a => new BSWrapperObject_UnityEngine_Transform(
                        MaskUtilities.FindRootSortOverrideCanvas( WrapperHelper.UnwrapObject < Transform >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetStencilDepth"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStencilDepth(transform, stopAfter)",
                    a => new BSObject(
                        ( decimal ) MaskUtilities.GetStencilDepth(
                            WrapperHelper.UnwrapObject < Transform >( a[0] ),
                            WrapperHelper.UnwrapObject < Transform >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["IsDescendantOrSelf"] = new BSFunctionReference(
                new BSFunction(
                    "function IsDescendantOrSelf(father, child)",
                    a => MaskUtilities.IsDescendantOrSelf(
                        WrapperHelper.UnwrapObject < Transform >( a[0] ),
                        WrapperHelper.UnwrapObject < Transform >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetRectMaskForClippable"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRectMaskForClippable(clippable)",
                    a => new BSWrapperObject_UnityEngine_UI_RectMask2D(
                        MaskUtilities.GetRectMaskForClippable( WrapperHelper.UnwrapObject < IClippable >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

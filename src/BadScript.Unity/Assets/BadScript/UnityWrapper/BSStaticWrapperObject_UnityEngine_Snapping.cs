using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Snapping : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Snapping() : base( typeof( Snapping ) )
        {
            m_StaticProperties["Snap"] = new BSFunctionReference(
                new BSFunction(
                    "function Snap(val, snap)",
                    a => new BSObject(
                        ( decimal ) Snapping.Snap(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Snap"] = new BSFunctionReference(
                new BSFunction(
                    "function Snap(val, snap)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Snapping.Snap(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

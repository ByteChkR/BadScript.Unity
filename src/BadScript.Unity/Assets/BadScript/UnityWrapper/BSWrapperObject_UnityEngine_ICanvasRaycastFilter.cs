using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ICanvasRaycastFilter : BSWrapperObject < ICanvasRaycastFilter >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ICanvasRaycastFilter( ICanvasRaycastFilter obj ) : base( obj )
        {
            m_Properties["IsRaycastLocationValid"] = new BSFunctionReference(
                new BSFunction(
                    "function IsRaycastLocationValid(sp, eventCamera)",
                    a => m_InternalObject.IsRaycastLocationValid(
                        WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                        WrapperHelper.UnwrapObject < Camera >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

        }

        #endregion
    }

}

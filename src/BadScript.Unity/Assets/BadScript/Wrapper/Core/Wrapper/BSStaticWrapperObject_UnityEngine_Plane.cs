using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Plane : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Plane() : base( typeof( Plane ) )
        {
            m_StaticProperties["Translate"] = new BSFunctionReference(
                new BSFunction(
                    "function Translate(plane, translation)",
                    a => new BSWrapperObject_UnityEngine_Plane(
                        Plane.Translate(
                            WrapperHelper.UnwrapObject < Plane >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

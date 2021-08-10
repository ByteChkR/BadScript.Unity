using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor() : base(
            typeof( LinearColor ) )
        {
            m_StaticProperties["Convert"] = new BSFunctionReference(
                new BSFunction(
                    "function Convert(color, intensity)",
                    a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor(
                        LinearColor.Convert(
                            WrapperHelper.UnwrapObject < Color >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

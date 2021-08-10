using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_LightmapperUtils : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_LightmapperUtils() : base(
            typeof( LightmapperUtils ) )
        {
            m_StaticProperties["ExtractIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function ExtractIndirect(l)",
                    a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor(
                        LightmapperUtils.ExtractIndirect( WrapperHelper.UnwrapObject < Light >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ExtractInnerCone"] = new BSFunctionReference(
                new BSFunction(
                    "function ExtractInnerCone(l)",
                    a => new BSObject(
                        ( decimal ) LightmapperUtils.ExtractInnerCone( WrapperHelper.UnwrapObject < Light >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

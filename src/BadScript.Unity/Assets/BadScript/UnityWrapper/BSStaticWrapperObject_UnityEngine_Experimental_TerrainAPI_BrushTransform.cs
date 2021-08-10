using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_BrushTransform : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_BrushTransform() : base(
            typeof( BrushTransform ) )
        {
            m_StaticProperties["FromRect"] = new BSFunctionReference(
                new BSFunction(
                    "function FromRect(brushRect)",
                    a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_BrushTransform(
                        BrushTransform.FromRect( WrapperHelper.UnwrapObject < Rect >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngineInternal;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngineInternal_APIUpdaterRuntimeServices : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngineInternal_APIUpdaterRuntimeServices() : base(
            typeof( APIUpdaterRuntimeServices ) )
        {
            m_StaticProperties["AddComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function AddComponent(go, sourceInfo, name)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        APIUpdaterRuntimeServices.AddComponent(
                            WrapperHelper.UnwrapObject < GameObject >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}

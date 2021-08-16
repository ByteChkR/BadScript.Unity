using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_LayerMask : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_LayerMask() : base( typeof( LayerMask ) )
        {
            m_StaticProperties["LayerToName"] = new BSFunctionReference(
                new BSFunction(
                    "function LayerToName(layer)",
                    a => new BSObject( LayerMask.LayerToName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NameToLayer"] = new BSFunctionReference(
                new BSFunction(
                    "function NameToLayer(layerName)",
                    a => new BSObject(
                        ( decimal ) LayerMask.NameToLayer( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Material : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Material() : base( typeof( Material ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(scriptContents)",
                    a => new BSWrapperObject_UnityEngine_Material(
                        Material.Create( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

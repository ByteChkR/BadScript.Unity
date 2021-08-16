using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_MonoBehaviour : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_MonoBehaviour() : base( typeof( MonoBehaviour ) )
        {
            m_StaticProperties["print"] = new BSFunctionReference(
                new BSFunction(
                    "function print(message)",
                    a =>
                    {
                        MonoBehaviour.print( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

        }

        #endregion
    }

}

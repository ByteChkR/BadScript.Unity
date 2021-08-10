using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_JsonUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_JsonUtility() : base( typeof( JsonUtility ) )
        {
            m_StaticProperties["ToJson"] = new BSFunctionReference(
                new BSFunction(
                    "function ToJson(obj)",
                    a => new BSObject( JsonUtility.ToJson( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ToJson"] = new BSFunctionReference(
                new BSFunction(
                    "function ToJson(obj, prettyPrint)",
                    a => new BSObject(
                        JsonUtility.ToJson(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

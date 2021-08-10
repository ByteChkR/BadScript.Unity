using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_StackTraceUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_StackTraceUtility() : base( typeof( StackTraceUtility ) )
        {
            m_StaticProperties["ExtractStringFromException"] = new BSFunctionReference(
                new BSFunction(
                    "function ExtractStringFromException(exception)",
                    a => new BSObject(
                        StackTraceUtility.ExtractStringFromException( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

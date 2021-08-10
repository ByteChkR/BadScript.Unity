using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UnityEventQueueSystem : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UnityEventQueueSystem() : base( typeof( UnityEventQueueSystem ) )
        {
            m_StaticProperties["GenerateEventIdForPayload"] = new BSFunctionReference(
                new BSFunction(
                    "function GenerateEventIdForPayload(eventPayloadName)",
                    a => new BSObject(
                        UnityEventQueueSystem.GenerateEventIdForPayload(
                            WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.tvOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_tvOS_Device : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_tvOS_Device() : base( typeof( Device ) )
        {
            m_StaticProperties["systemVersion"] = new BSReflectionReference(
                () => new BSObject( Device.systemVersion ),
                null );

            m_StaticProperties["vendorIdentifier"] = new BSReflectionReference(
                () => new BSObject( Device.vendorIdentifier ),
                null );

            m_StaticProperties["advertisingIdentifier"] = new BSReflectionReference(
                () => new BSObject( Device.advertisingIdentifier ),
                null );

            m_StaticProperties["advertisingTrackingEnabled"] = new BSReflectionReference(
                () => Device.advertisingTrackingEnabled ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

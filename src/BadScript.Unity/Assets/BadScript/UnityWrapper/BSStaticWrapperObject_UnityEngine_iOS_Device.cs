using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.iOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_iOS_Device : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_iOS_Device() : base( typeof( Device ) )
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

            m_StaticProperties["hideHomeButton"] = new BSReflectionReference(
                () => Device.hideHomeButton ? BSObject.One : BSObject.Zero,
                x => Device.hideHomeButton = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["lowPowerModeEnabled"] = new BSReflectionReference(
                () => Device.lowPowerModeEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["wantsSoftwareDimming"] = new BSReflectionReference(
                () => Device.wantsSoftwareDimming ? BSObject.One : BSObject.Zero,
                x => Device.wantsSoftwareDimming = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["iosAppOnMac"] = new BSReflectionReference(
                () => Device.iosAppOnMac ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

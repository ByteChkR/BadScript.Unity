using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.CrashReportHandler;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_CrashReportHandler_CrashReportHandler : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_CrashReportHandler_CrashReportHandler() : base(
            typeof( CrashReportHandler ) )
        {
            m_StaticProperties["enableCaptureExceptions"] = new BSReflectionReference(
                () => CrashReportHandler.enableCaptureExceptions ? BSObject.One : BSObject.Zero,
                x => CrashReportHandler.enableCaptureExceptions = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["logBufferSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) CrashReportHandler.logBufferSize ),
                x => CrashReportHandler.logBufferSize = WrapperHelper.UnwrapObject < uint >( x ) );

            m_StaticProperties["GetUserMetadata"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUserMetadata(key)",
                    a => new BSObject(
                        CrashReportHandler.GetUserMetadata( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

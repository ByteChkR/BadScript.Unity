using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_UnityWebRequest : BSWrapperObject < UnityWebRequest >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_UnityWebRequest( UnityWebRequest obj ) : base( obj )
        {
            m_Properties["disposeCertificateHandlerOnDispose"] = new BSReflectionReference(
                () => m_InternalObject.disposeCertificateHandlerOnDispose ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.disposeCertificateHandlerOnDispose = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["disposeDownloadHandlerOnDispose"] = new BSReflectionReference(
                () => m_InternalObject.disposeDownloadHandlerOnDispose ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.disposeDownloadHandlerOnDispose = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["disposeUploadHandlerOnDispose"] = new BSReflectionReference(
                () => m_InternalObject.disposeUploadHandlerOnDispose ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.disposeUploadHandlerOnDispose = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["method"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.method ),
                x => m_InternalObject.method = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["error"] = new BSReflectionReference( () => new BSObject( m_InternalObject.error ), null );

            m_Properties["useHttpContinue"] = new BSReflectionReference(
                () => m_InternalObject.useHttpContinue ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useHttpContinue = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["url"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.url ),
                x => m_InternalObject.url = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["uri"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Uri( m_InternalObject.uri ),
                x => m_InternalObject.uri = WrapperHelper.UnwrapObject < Uri >( x ) );

            m_Properties["responseCode"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.responseCode ),
                null );

            m_Properties["uploadProgress"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.uploadProgress ),
                null );

            m_Properties["isModifiable"] = new BSReflectionReference(
                () => m_InternalObject.isModifiable ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isDone"] = new BSReflectionReference(
                () => m_InternalObject.isDone ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isNetworkError"] = new BSReflectionReference(
                () => m_InternalObject.isNetworkError ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isHttpError"] = new BSReflectionReference(
                () => m_InternalObject.isHttpError ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["downloadProgress"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.downloadProgress ),
                null );

            m_Properties["uploadedBytes"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.uploadedBytes ),
                null );

            m_Properties["downloadedBytes"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.downloadedBytes ),
                null );

            m_Properties["redirectLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.redirectLimit ),
                x => m_InternalObject.redirectLimit = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["chunkedTransfer"] = new BSReflectionReference(
                () => m_InternalObject.chunkedTransfer ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.chunkedTransfer = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["uploadHandler"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Networking_UploadHandler( m_InternalObject.uploadHandler ),
                x => m_InternalObject.uploadHandler = WrapperHelper.UnwrapObject < UploadHandler >( x ) );

            m_Properties["downloadHandler"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Networking_DownloadHandler( m_InternalObject.downloadHandler ),
                x => m_InternalObject.downloadHandler = WrapperHelper.UnwrapObject < DownloadHandler >( x ) );

            m_Properties["certificateHandler"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Networking_CertificateHandler(
                    m_InternalObject.certificateHandler ),
                x => m_InternalObject.certificateHandler = WrapperHelper.UnwrapObject < CertificateHandler >( x ) );

            m_Properties["timeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.timeout ),
                x => m_InternalObject.timeout = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["isError"] = new BSReflectionReference(
                () => m_InternalObject.isNetworkError ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["GetRequestHeader"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRequestHeader(name)",
                    a => new BSObject(
                        m_InternalObject.GetRequestHeader( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetResponseHeader"] = new BSFunctionReference(
                new BSFunction(
                    "function GetResponseHeader(name)",
                    a => new BSObject(
                        m_InternalObject.GetResponseHeader( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

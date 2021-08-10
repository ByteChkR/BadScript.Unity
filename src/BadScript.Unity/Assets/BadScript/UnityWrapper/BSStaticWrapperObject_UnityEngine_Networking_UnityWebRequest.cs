using System;
using System.Text;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequest : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequest() : base( typeof( UnityWebRequest ) )
        {
            m_StaticProperties["kHttpVerbGET"] = new BSReflectionReference(
                () => new BSObject( UnityWebRequest.kHttpVerbGET ),
                null );

            m_StaticProperties["kHttpVerbHEAD"] = new BSReflectionReference(
                () => new BSObject( UnityWebRequest.kHttpVerbHEAD ),
                null );

            m_StaticProperties["kHttpVerbPOST"] = new BSReflectionReference(
                () => new BSObject( UnityWebRequest.kHttpVerbPOST ),
                null );

            m_StaticProperties["kHttpVerbPUT"] = new BSReflectionReference(
                () => new BSObject( UnityWebRequest.kHttpVerbPUT ),
                null );

            m_StaticProperties["kHttpVerbCREATE"] = new BSReflectionReference(
                () => new BSObject( UnityWebRequest.kHttpVerbCREATE ),
                null );

            m_StaticProperties["kHttpVerbDELETE"] = new BSReflectionReference(
                () => new BSObject( UnityWebRequest.kHttpVerbDELETE ),
                null );

            m_StaticProperties["Get"] = new BSFunctionReference(
                new BSFunction(
                    "function Get(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Get( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Get"] = new BSFunctionReference(
                new BSFunction(
                    "function Get(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Get( WrapperHelper.UnwrapObject < Uri >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Delete"] = new BSFunctionReference(
                new BSFunction(
                    "function Delete(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Delete( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Delete"] = new BSFunctionReference(
                new BSFunction(
                    "function Delete(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Delete( WrapperHelper.UnwrapObject < Uri >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Head"] = new BSFunctionReference(
                new BSFunction(
                    "function Head(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Head( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Head"] = new BSFunctionReference(
                new BSFunction(
                    "function Head(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Head( WrapperHelper.UnwrapObject < Uri >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Put"] = new BSFunctionReference(
                new BSFunction(
                    "function Put(uri, bodyData)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Put(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Put"] = new BSFunctionReference(
                new BSFunction(
                    "function Put(uri, bodyData)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Put(
                            WrapperHelper.UnwrapObject < Uri >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Post"] = new BSFunctionReference(
                new BSFunction(
                    "function Post(uri, postData)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Post(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Post"] = new BSFunctionReference(
                new BSFunction(
                    "function Post(uri, postData)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Post(
                            WrapperHelper.UnwrapObject < Uri >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Post"] = new BSFunctionReference(
                new BSFunction(
                    "function Post(uri, formData)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Post(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < WWWForm >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Post"] = new BSFunctionReference(
                new BSFunction(
                    "function Post(uri, formData)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequest.Post(
                            WrapperHelper.UnwrapObject < Uri >( a[0] ),
                            WrapperHelper.UnwrapObject < WWWForm >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["EscapeURL"] = new BSFunctionReference(
                new BSFunction(
                    "function EscapeURL(s)",
                    a => new BSObject( UnityWebRequest.EscapeURL( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["EscapeURL"] = new BSFunctionReference(
                new BSFunction(
                    "function EscapeURL(s, e)",
                    a => new BSObject(
                        UnityWebRequest.EscapeURL(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Encoding >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["UnEscapeURL"] = new BSFunctionReference(
                new BSFunction(
                    "function UnEscapeURL(s)",
                    a => new BSObject( UnityWebRequest.UnEscapeURL( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["UnEscapeURL"] = new BSFunctionReference(
                new BSFunction(
                    "function UnEscapeURL(s, e)",
                    a => new BSObject(
                        UnityWebRequest.UnEscapeURL(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Encoding >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

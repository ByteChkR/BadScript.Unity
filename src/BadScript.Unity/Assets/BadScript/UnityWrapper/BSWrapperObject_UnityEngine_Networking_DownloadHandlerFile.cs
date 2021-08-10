using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_DownloadHandlerFile : BSWrapperObject < DownloadHandlerFile >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_DownloadHandlerFile( DownloadHandlerFile obj ) : base( obj )
        {
            m_Properties["removeFileOnAbort"] = new BSReflectionReference(
                () => m_InternalObject.removeFileOnAbort ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.removeFileOnAbort = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isDone"] = new BSReflectionReference(
                () => m_InternalObject.isDone ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["error"] = new BSReflectionReference( () => new BSObject( m_InternalObject.error ), null );
            m_Properties["text"] = new BSReflectionReference( () => new BSObject( m_InternalObject.text ), null );

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

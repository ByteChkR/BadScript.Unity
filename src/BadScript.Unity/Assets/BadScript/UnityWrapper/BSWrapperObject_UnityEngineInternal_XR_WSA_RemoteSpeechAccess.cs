using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngineInternal.XR.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngineInternal_XR_WSA_RemoteSpeechAccess : BSWrapperObject < RemoteSpeechAccess >

    {
        #region Public

        public BSWrapperObject_UnityEngineInternal_XR_WSA_RemoteSpeechAccess( RemoteSpeechAccess obj ) : base( obj )
        {
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

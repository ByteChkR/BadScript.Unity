using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_UploadHandlerFile : BSWrapperObject < UploadHandlerFile >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_UploadHandlerFile( UploadHandlerFile obj ) : base( obj )
        {
            m_Properties["contentType"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.contentType ),
                x => m_InternalObject.contentType = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["progress"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.progress ),
                null );

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

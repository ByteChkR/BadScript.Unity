using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Networking_MultipartFormDataSection : BSWrapperObject < MultipartFormDataSection >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_MultipartFormDataSection( MultipartFormDataSection obj ) : base(
            obj )
        {
            m_Properties["sectionName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.sectionName ),
                null );

            m_Properties["fileName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.fileName ),
                null );

            m_Properties["contentType"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.contentType ),
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

using System.Security.Cryptography.X509Certificates;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class
        BSStaticWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate() : base(
            typeof( X509Certificate ) )
        {
            m_StaticProperties["CreateFromCertFile"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateFromCertFile(filename)",
                    a => new BSWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate(
                        X509Certificate.CreateFromCertFile( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CreateFromSignedFile"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateFromSignedFile(filename)",
                    a => new BSWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate(
                        X509Certificate.CreateFromSignedFile( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

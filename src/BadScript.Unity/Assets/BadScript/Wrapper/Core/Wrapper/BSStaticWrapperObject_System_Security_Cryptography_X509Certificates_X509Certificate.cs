using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate() : base(typeof(System.Security.Cryptography.X509Certificates.X509Certificate))
        {
            m_StaticProperties["CreateFromCertFile"] = new BSFunctionReference(new BSFunction("function CreateFromCertFile(filename)", a => new BSWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate(System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromCertFile(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["CreateFromSignedFile"] = new BSFunctionReference(new BSFunction("function CreateFromSignedFile(filename)", a => new BSWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate(System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromSignedFile(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
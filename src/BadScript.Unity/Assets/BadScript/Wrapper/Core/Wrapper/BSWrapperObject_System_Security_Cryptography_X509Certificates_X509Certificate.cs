using System.Security.Cryptography.X509Certificates;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class
        BSWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate : BSWrapperObject <
            X509Certificate >

    {
        #region Public

        public BSWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate( X509Certificate obj ) :
            base( obj )
        {
            m_Properties["Issuer"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Issuer ), null );
            m_Properties["Subject"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Subject ), null );

            m_Properties["Handle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( m_InternalObject.Handle ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < X509Certificate >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetCertHashString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCertHashString()",
                    a => new BSObject( m_InternalObject.GetCertHashString() ),
                    0 ) );

            m_Properties["GetEffectiveDateString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEffectiveDateString()",
                    a => new BSObject( m_InternalObject.GetEffectiveDateString() ),
                    0 ) );

            m_Properties["GetExpirationDateString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetExpirationDateString()",
                    a => new BSObject( m_InternalObject.GetExpirationDateString() ),
                    0 ) );

            m_Properties["GetFormat"] = new BSFunctionReference(
                new BSFunction( "function GetFormat()", a => new BSObject( m_InternalObject.GetFormat() ), 0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["GetIssuerName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIssuerName()",
                    a => new BSObject( m_InternalObject.GetIssuerName() ),
                    0 ) );

            m_Properties["GetKeyAlgorithm"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKeyAlgorithm()",
                    a => new BSObject( m_InternalObject.GetKeyAlgorithm() ),
                    0 ) );

            m_Properties["GetKeyAlgorithmParametersString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKeyAlgorithmParametersString()",
                    a => new BSObject( m_InternalObject.GetKeyAlgorithmParametersString() ),
                    0 ) );

            m_Properties["GetName"] = new BSFunctionReference(
                new BSFunction( "function GetName()", a => new BSObject( m_InternalObject.GetName() ), 0 ) );

            m_Properties["GetPublicKeyString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPublicKeyString()",
                    a => new BSObject( m_InternalObject.GetPublicKeyString() ),
                    0 ) );

            m_Properties["GetRawCertDataString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRawCertDataString()",
                    a => new BSObject( m_InternalObject.GetRawCertDataString() ),
                    0 ) );

            m_Properties["GetSerialNumberString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSerialNumberString()",
                    a => new BSObject( m_InternalObject.GetSerialNumberString() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(fVerbose)",
                    a => new BSObject( m_InternalObject.ToString( WrapperHelper.UnwrapObject < bool >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Import"] = new BSFunctionReference(
                new BSFunction(
                    "function Import(fileName)",
                    a =>
                    {
                        m_InternalObject.Import( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Dispose"] = new BSFunctionReference(
                new BSFunction(
                    "function Dispose()",
                    a =>
                    {
                        m_InternalObject.Dispose();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Reset"] = new BSFunctionReference(
                new BSFunction(
                    "function Reset()",
                    a =>
                    {
                        m_InternalObject.Reset();

                        return new BSObject( null );
                    },
                    0 ) );

        }

        #endregion
    }

}

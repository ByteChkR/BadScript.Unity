using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Uri : BSWrapperObject < Uri >

    {
        #region Public

        public BSWrapperObject_System_Uri( Uri obj ) : base( obj )
        {
            m_Properties["AbsolutePath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.AbsolutePath ),
                null );

            m_Properties["AbsoluteUri"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.AbsoluteUri ),
                null );

            m_Properties["LocalPath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.LocalPath ),
                null );

            m_Properties["Authority"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.Authority ),
                null );

            m_Properties["IsDefaultPort"] = new BSReflectionReference(
                () => m_InternalObject.IsDefaultPort ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsFile"] = new BSReflectionReference(
                () => m_InternalObject.IsFile ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsLoopback"] = new BSReflectionReference(
                () => m_InternalObject.IsLoopback ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["PathAndQuery"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.PathAndQuery ),
                null );

            m_Properties["IsUnc"] = new BSReflectionReference(
                () => m_InternalObject.IsUnc ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Host"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Host ), null );

            m_Properties["Port"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Port ),
                null );

            m_Properties["Query"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Query ), null );

            m_Properties["Fragment"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.Fragment ),
                null );

            m_Properties["Scheme"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Scheme ), null );

            m_Properties["OriginalString"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.OriginalString ),
                null );

            m_Properties["DnsSafeHost"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.DnsSafeHost ),
                null );

            m_Properties["IdnHost"] = new BSReflectionReference( () => new BSObject( m_InternalObject.IdnHost ), null );

            m_Properties["IsAbsoluteUri"] = new BSReflectionReference(
                () => m_InternalObject.IsAbsoluteUri ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["UserEscaped"] = new BSReflectionReference(
                () => m_InternalObject.UserEscaped ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["UserInfo"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.UserInfo ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(comparand)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["MakeRelativeUri"] = new BSFunctionReference(
                new BSFunction(
                    "function MakeRelativeUri(uri)",
                    a => new BSWrapperObject_System_Uri(
                        m_InternalObject.MakeRelativeUri( WrapperHelper.UnwrapObject < Uri >( a[0] ) ) ),
                    1 ) );

            m_Properties["MakeRelative"] = new BSFunctionReference(
                new BSFunction(
                    "function MakeRelative(toUri)",
                    a => new BSObject( m_InternalObject.MakeRelative( WrapperHelper.UnwrapObject < Uri >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsBaseOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IsBaseOf(uri)",
                    a => m_InternalObject.IsBaseOf( WrapperHelper.UnwrapObject < Uri >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

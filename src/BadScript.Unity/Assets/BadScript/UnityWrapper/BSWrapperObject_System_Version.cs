using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Version : BSWrapperObject < Version >

    {
        #region Public

        public BSWrapperObject_System_Version( Version obj ) : base( obj )
        {
            m_Properties["Major"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Major ),
                null );

            m_Properties["Minor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Minor ),
                null );

            m_Properties["Build"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Build ),
                null );

            m_Properties["Revision"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Revision ),
                null );

            m_Properties["MajorRevision"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MajorRevision ),
                null );

            m_Properties["MinorRevision"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MinorRevision ),
                null );

            m_Properties["CompareTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTo(version)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTo(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < Version >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Version >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(fieldCount)",
                    a => new BSObject( m_InternalObject.ToString( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

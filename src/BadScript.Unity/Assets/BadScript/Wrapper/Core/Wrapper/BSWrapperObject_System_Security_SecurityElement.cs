using System.Collections;
using System.Security;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Security_SecurityElement : BSWrapperObject < SecurityElement >

    {
        #region Public

        public BSWrapperObject_System_Security_SecurityElement( SecurityElement obj ) : base( obj )
        {
            m_Properties["Attributes"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Collections_Hashtable( m_InternalObject.Attributes ),
                x => m_InternalObject.Attributes = WrapperHelper.UnwrapObject < Hashtable >( x ) );

            m_Properties["Children"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Collections_ArrayList( m_InternalObject.Children ),
                x => m_InternalObject.Children = WrapperHelper.UnwrapObject < ArrayList >( x ) );

            m_Properties["Tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.Tag ),
                x => m_InternalObject.Tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Text"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.Text ),
                x => m_InternalObject.Text = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["AddAttribute"] = new BSFunctionReference(
                new BSFunction(
                    "function AddAttribute(name, value)",
                    a =>
                    {
                        m_InternalObject.AddAttribute(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddChild"] = new BSFunctionReference(
                new BSFunction(
                    "function AddChild(child)",
                    a =>
                    {
                        m_InternalObject.AddChild( WrapperHelper.UnwrapObject < SecurityElement >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Attribute"] = new BSFunctionReference(
                new BSFunction(
                    "function Attribute(name)",
                    a => new BSObject( m_InternalObject.Attribute( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["Copy"] = new BSFunctionReference(
                new BSFunction(
                    "function Copy()",
                    a => new BSWrapperObject_System_Security_SecurityElement( m_InternalObject.Copy() ),
                    0 ) );

            m_Properties["Equal"] = new BSFunctionReference(
                new BSFunction(
                    "function Equal(other)",
                    a => m_InternalObject.Equal( WrapperHelper.UnwrapObject < SecurityElement >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["SearchForChildByTag"] = new BSFunctionReference(
                new BSFunction(
                    "function SearchForChildByTag(tag)",
                    a => new BSWrapperObject_System_Security_SecurityElement(
                        m_InternalObject.SearchForChildByTag( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["SearchForTextOfTag"] = new BSFunctionReference(
                new BSFunction(
                    "function SearchForTextOfTag(tag)",
                    a => new BSObject(
                        m_InternalObject.SearchForTextOfTag( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

        }

        #endregion
    }

}

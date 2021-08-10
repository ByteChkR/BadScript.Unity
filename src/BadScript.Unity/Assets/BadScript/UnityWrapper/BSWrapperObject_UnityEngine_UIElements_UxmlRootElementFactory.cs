using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_UxmlRootElementFactory : BSWrapperObject < UxmlRootElementFactory >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_UxmlRootElementFactory( UxmlRootElementFactory obj ) : base( obj )
        {
            m_Properties["uxmlName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.uxmlName ),
                null );

            m_Properties["uxmlQualifiedName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.uxmlQualifiedName ),
                null );

            m_Properties["substituteForTypeName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.substituteForTypeName ),
                null );

            m_Properties["substituteForTypeNamespace"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.substituteForTypeNamespace ),
                null );

            m_Properties["substituteForTypeQualifiedName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.substituteForTypeQualifiedName ),
                null );

            m_Properties["uxmlNamespace"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.uxmlNamespace ),
                null );

            m_Properties["canHaveAnyAttribute"] = new BSReflectionReference(
                () => m_InternalObject.canHaveAnyAttribute ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(bag, cc)",
                    a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(
                        m_InternalObject.Create(
                            WrapperHelper.UnwrapObject < IUxmlAttributes >( a[0] ),
                            WrapperHelper.UnwrapObject < CreationContext >( a[1] ) ) ),
                    2 ) );

            m_Properties["AcceptsAttributeBag"] = new BSFunctionReference(
                new BSFunction(
                    "function AcceptsAttributeBag(bag, cc)",
                    a => m_InternalObject.AcceptsAttributeBag(
                        WrapperHelper.UnwrapObject < IUxmlAttributes >( a[0] ),
                        WrapperHelper.UnwrapObject < CreationContext >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

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

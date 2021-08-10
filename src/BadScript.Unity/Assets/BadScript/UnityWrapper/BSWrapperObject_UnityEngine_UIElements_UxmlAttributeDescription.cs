using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_UxmlAttributeDescription : BSWrapperObject < UxmlAttributeDescription >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_UxmlAttributeDescription( UxmlAttributeDescription obj ) : base(
            obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["type"] = new BSReflectionReference( () => new BSObject( m_InternalObject.type ), null );

            m_Properties["typeNamespace"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.typeNamespace ),
                null );

            m_Properties["defaultValueAsString"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.defaultValueAsString ),
                null );

            m_Properties["restriction"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_UxmlTypeRestriction( m_InternalObject.restriction ),
                x => m_InternalObject.restriction = WrapperHelper.UnwrapObject < UxmlTypeRestriction >( x ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_UxmlValueBounds : BSWrapperObject < UxmlValueBounds >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_UxmlValueBounds( UxmlValueBounds obj ) : base( obj )
        {
            m_Properties["min"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.min ),
                x => m_InternalObject.min = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["max"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.max ),
                x => m_InternalObject.max = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["excludeMin"] = new BSReflectionReference(
                () => m_InternalObject.excludeMin ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.excludeMin = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["excludeMax"] = new BSReflectionReference(
                () => m_InternalObject.excludeMax ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.excludeMax = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < UxmlTypeRestriction >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_Clickable : BSWrapperObject < Clickable >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_Clickable( Clickable obj ) : base( obj )
        {
            m_Properties["lastMousePosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.lastMousePosition ),
                null );

            m_Properties["target"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VisualElement( m_InternalObject.target ),
                x => m_InternalObject.target = WrapperHelper.UnwrapObject < VisualElement >( x ) );

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

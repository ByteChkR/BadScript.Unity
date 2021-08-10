using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_DropdownMenuAction : BSWrapperObject < DropdownMenuAction >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_DropdownMenuAction( DropdownMenuAction obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.name ), null );

            m_Properties["eventInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_DropdownMenuEventInfo( m_InternalObject.eventInfo ),
                null );

            m_Properties["userData"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.userData ),
                null );

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

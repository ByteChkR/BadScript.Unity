using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_DropdownMenuSeparator : BSWrapperObject < DropdownMenuSeparator >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_DropdownMenuSeparator( DropdownMenuSeparator obj ) : base( obj )
        {
            m_Properties["subMenuPath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.subMenuPath ),
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

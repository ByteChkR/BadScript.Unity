using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_UxmlRootElementTraits : BSWrapperObject < UxmlRootElementTraits >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_UxmlRootElementTraits( UxmlRootElementTraits obj ) : base( obj )
        {
            m_Properties["canHaveAnyAttribute"] = new BSReflectionReference(
                () => m_InternalObject.canHaveAnyAttribute ? BSObject.One : BSObject.Zero,
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

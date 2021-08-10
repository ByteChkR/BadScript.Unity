using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_ManipulatorActivationFilter : BSWrapperObject <
            ManipulatorActivationFilter >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_ManipulatorActivationFilter( ManipulatorActivationFilter obj ) :
            base( obj )
        {
            m_Properties["clickCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clickCount ),
                x => m_InternalObject.clickCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < ManipulatorActivationFilter >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Matches"] = new BSFunctionReference(
                new BSFunction(
                    "function Matches(e)",
                    a => m_InternalObject.Matches( WrapperHelper.UnwrapObject < IMouseEvent >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Matches"] = new BSFunctionReference(
                new BSFunction(
                    "function Matches(e)",
                    a => m_InternalObject.Matches( WrapperHelper.UnwrapObject < IPointerEvent >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

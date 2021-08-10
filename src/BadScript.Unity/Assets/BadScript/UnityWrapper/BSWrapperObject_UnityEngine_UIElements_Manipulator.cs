using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_Manipulator : BSWrapperObject < Manipulator >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_Manipulator( Manipulator obj ) : base( obj )
        {
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

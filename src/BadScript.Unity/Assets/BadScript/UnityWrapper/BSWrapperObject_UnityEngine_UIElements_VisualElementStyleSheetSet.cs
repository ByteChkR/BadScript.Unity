using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet : BSWrapperObject < VisualElementStyleSheetSet
        >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet( VisualElementStyleSheetSet obj ) :
            base( obj )
        {
            m_Properties["count"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.count ),
                null );

            m_Properties["Remove"] = new BSFunctionReference(
                new BSFunction(
                    "function Remove(styleSheet)",
                    a => m_InternalObject.Remove( WrapperHelper.UnwrapObject < StyleSheet >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(styleSheet)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < StyleSheet >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < VisualElementStyleSheetSet >( a[0] ) )
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

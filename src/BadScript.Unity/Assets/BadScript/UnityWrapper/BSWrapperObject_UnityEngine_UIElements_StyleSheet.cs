using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_StyleSheet : BSWrapperObject < StyleSheet >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_StyleSheet( StyleSheet obj ) : base( obj )
        {
            m_Properties["contentHash"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.contentHash ),
                x => m_InternalObject.contentHash = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

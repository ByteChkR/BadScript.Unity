using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_StyleLength : BSWrapperObject < StyleLength >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_StyleLength( StyleLength obj ) : base( obj )
        {
            m_Properties["value"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_Length( m_InternalObject.value ),
                x => m_InternalObject.value = WrapperHelper.UnwrapObject < Length >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < StyleLength >( a[0] ) )
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

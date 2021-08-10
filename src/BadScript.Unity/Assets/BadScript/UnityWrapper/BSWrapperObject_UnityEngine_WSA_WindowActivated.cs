using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WSA_WindowActivated : BSWrapperObject < WindowActivated >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WSA_WindowActivated( WindowActivated obj ) : base( obj )
        {
            m_Properties["Method"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_MethodInfo( m_InternalObject.Method ),
                null );

            m_Properties["Target"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Target ),
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

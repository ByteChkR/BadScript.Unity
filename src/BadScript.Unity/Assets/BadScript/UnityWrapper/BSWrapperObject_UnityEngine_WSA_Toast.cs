using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WSA_Toast : BSWrapperObject < Toast >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WSA_Toast( Toast obj ) : base( obj )
        {
            m_Properties["arguments"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.arguments ),
                x => m_InternalObject.arguments = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["activated"] = new BSReflectionReference(
                () => m_InternalObject.activated ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["dismissed"] = new BSReflectionReference(
                () => m_InternalObject.dismissed ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["dismissedByUser"] = new BSReflectionReference(
                () => m_InternalObject.dismissedByUser ? BSObject.One : BSObject.Zero,
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

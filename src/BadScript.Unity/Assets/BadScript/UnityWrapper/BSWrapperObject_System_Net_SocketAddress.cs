using System.Net;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Net_SocketAddress : BSWrapperObject < SocketAddress >

    {
        #region Public

        public BSWrapperObject_System_Net_SocketAddress( SocketAddress obj ) : base( obj )
        {
            m_Properties["Size"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Size ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(comparand)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

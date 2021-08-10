using System.Net;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Net_EndPoint : BSWrapperObject < EndPoint >

    {
        #region Public

        public BSWrapperObject_System_Net_EndPoint( EndPoint obj ) : base( obj )
        {
            m_Properties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(socketAddress)",
                    a => new BSWrapperObject_System_Net_EndPoint(
                        m_InternalObject.Create( WrapperHelper.UnwrapObject < SocketAddress >( a[0] ) ) ),
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

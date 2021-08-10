using System.Threading;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_System_Threading_CancellationTokenRegistration : BSWrapperObject < CancellationTokenRegistration
        >

    {
        #region Public

        public BSWrapperObject_System_Threading_CancellationTokenRegistration( CancellationTokenRegistration obj ) :
            base( obj )
        {
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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < CancellationTokenRegistration >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

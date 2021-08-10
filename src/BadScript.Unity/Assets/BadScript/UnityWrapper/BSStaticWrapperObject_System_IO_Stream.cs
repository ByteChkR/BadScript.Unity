using System.IO;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_IO_Stream : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_IO_Stream() : base( typeof( Stream ) )
        {
            m_StaticProperties["Null"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IO_Stream( Stream.Null ),
                null );

            m_StaticProperties["Synchronized"] = new BSFunctionReference(
                new BSFunction(
                    "function Synchronized(stream)",
                    a => new BSWrapperObject_System_IO_Stream(
                        Stream.Synchronized( WrapperHelper.UnwrapObject < Stream >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

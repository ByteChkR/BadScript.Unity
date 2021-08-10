using System.Threading;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Threading_CancellationToken : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Threading_CancellationToken() : base( typeof( CancellationToken ) )
        {
            m_StaticProperties["None"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_CancellationToken( CancellationToken.None ),
                null );

        }

        #endregion
    }

}

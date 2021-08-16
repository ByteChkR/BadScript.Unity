using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Threading_CancellationToken : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Threading_CancellationToken() : base(typeof(System.Threading.CancellationToken))
        {
            m_StaticProperties["None"] = new BSReflectionReference(() => new BSWrapperObject_System_Threading_CancellationToken(System.Threading.CancellationToken.None), null);

        }
    }

}
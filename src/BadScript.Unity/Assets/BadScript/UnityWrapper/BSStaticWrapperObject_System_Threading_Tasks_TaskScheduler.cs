using System.Threading.Tasks;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Threading_Tasks_TaskScheduler : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Threading_Tasks_TaskScheduler() : base( typeof( TaskScheduler ) )
        {
            m_StaticProperties["Default"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_Tasks_TaskScheduler( TaskScheduler.Default ),
                null );

            m_StaticProperties["Current"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_Tasks_TaskScheduler( TaskScheduler.Current ),
                null );

        }

        #endregion
    }

}

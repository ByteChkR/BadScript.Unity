using System.Threading.Tasks;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Threading_Tasks_TaskScheduler : BSWrapperObject < TaskScheduler >

    {
        #region Public

        public BSWrapperObject_System_Threading_Tasks_TaskScheduler( TaskScheduler obj ) : base( obj )
        {
            m_Properties["MaximumConcurrencyLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaximumConcurrencyLevel ),
                null );

            m_Properties["Id"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Id ),
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

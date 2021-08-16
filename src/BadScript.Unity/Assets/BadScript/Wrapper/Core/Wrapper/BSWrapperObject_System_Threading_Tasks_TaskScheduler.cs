using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Threading_Tasks_TaskScheduler : BSWrapperObject<System.Threading.Tasks.TaskScheduler>

    {
        public BSWrapperObject_System_Threading_Tasks_TaskScheduler(System.Threading.Tasks.TaskScheduler obj) : base(obj)
        {
            m_Properties["MaximumConcurrencyLevel"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.MaximumConcurrencyLevel), null);
            m_Properties["Id"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Id), null);
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Runtime_CompilerServices_TaskAwaiter : BSWrapperObject<System.Runtime.CompilerServices.TaskAwaiter>

    {
        public BSWrapperObject_System_Runtime_CompilerServices_TaskAwaiter(System.Runtime.CompilerServices.TaskAwaiter obj) : base(obj)
        {
            m_Properties["IsCompleted"] = new BSReflectionReference(() => m_InternalObject.IsCompleted ? BSObject.One : BSObject.Zero, null);
            m_Properties["OnCompleted"] = new BSFunctionReference(new BSFunction("function OnCompleted(continuation)", a => {
                m_InternalObject.OnCompleted(WrapperHelper.UnwrapObject<System.Action>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["UnsafeOnCompleted"] = new BSFunctionReference(new BSFunction("function UnsafeOnCompleted(continuation)", a => {
                m_InternalObject.UnsafeOnCompleted(WrapperHelper.UnwrapObject<System.Action>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetResult"] = new BSFunctionReference(new BSFunction("function GetResult()", a => {
                m_InternalObject.GetResult();
                return new BSObject(null);
            }, 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
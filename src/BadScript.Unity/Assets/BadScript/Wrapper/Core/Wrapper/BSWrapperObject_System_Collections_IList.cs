using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_IList : BSWrapperObject<System.Collections.IList>

    {
        public BSWrapperObject_System_Collections_IList(System.Collections.IList obj) : base(obj)
        {
            m_Properties["IsReadOnly"] = new BSReflectionReference(() => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsFixedSize"] = new BSReflectionReference(() => m_InternalObject.IsFixedSize ? BSObject.One : BSObject.Zero, null);
            m_Properties["Add"] = new BSFunctionReference(new BSFunction("function Add(value)", a => new BSObject((decimal)m_InternalObject.Add(WrapperHelper.UnwrapObject<System.Object>(a[0]))), 1));
            m_Properties["Contains"] = new BSFunctionReference(new BSFunction("function Contains(value)", a => m_InternalObject.Contains(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Clear"] = new BSFunctionReference(new BSFunction("function Clear()", a => {
                m_InternalObject.Clear();
                return new BSObject(null);
            }, 0));
            m_Properties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(value)", a => new BSObject((decimal)m_InternalObject.IndexOf(WrapperHelper.UnwrapObject<System.Object>(a[0]))), 1));
            m_Properties["Insert"] = new BSFunctionReference(new BSFunction("function Insert(index, value)", a => {
                m_InternalObject.Insert(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Remove"] = new BSFunctionReference(new BSFunction("function Remove(value)", a => {
                m_InternalObject.Remove(WrapperHelper.UnwrapObject<System.Object>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["RemoveAt"] = new BSFunctionReference(new BSFunction("function RemoveAt(index)", a => {
                m_InternalObject.RemoveAt(WrapperHelper.UnwrapObject<System.Int32>(a[0]));
                return new BSObject(null);
            }, 1));

        }
    }

}
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_ICollection : BSWrapperObject<System.Collections.ICollection>

    {
        public BSWrapperObject_System_Collections_ICollection(System.Collections.ICollection obj) : base(obj)
        {
            m_Properties["Count"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Count), null);
            m_Properties["SyncRoot"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.SyncRoot), null);
            m_Properties["IsSynchronized"] = new BSReflectionReference(() => m_InternalObject.IsSynchronized ? BSObject.One : BSObject.Zero, null);
            m_Properties["CopyTo"] = new BSFunctionReference(new BSFunction("function CopyTo(array, index)", a => {
                m_InternalObject.CopyTo(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));

        }
    }

}
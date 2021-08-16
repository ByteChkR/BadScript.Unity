using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_Hashtable : BSWrapperObject<System.Collections.Hashtable>

    {
        public BSWrapperObject_System_Collections_Hashtable(System.Collections.Hashtable obj) : base(obj)
        {
            m_Properties["IsReadOnly"] = new BSReflectionReference(() => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsFixedSize"] = new BSReflectionReference(() => m_InternalObject.IsFixedSize ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsSynchronized"] = new BSReflectionReference(() => m_InternalObject.IsSynchronized ? BSObject.One : BSObject.Zero, null);
            m_Properties["Keys"] = new BSReflectionReference(() => new BSWrapperObject_System_Collections_ICollection(m_InternalObject.Keys), null);
            m_Properties["Values"] = new BSReflectionReference(() => new BSWrapperObject_System_Collections_ICollection(m_InternalObject.Values), null);
            m_Properties["SyncRoot"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.SyncRoot), null);
            m_Properties["Count"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Count), null);
            m_Properties["Add"] = new BSFunctionReference(new BSFunction("function Add(key, value)", a => {
                m_InternalObject.Add(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Clear"] = new BSFunctionReference(new BSFunction("function Clear()", a => {
                m_InternalObject.Clear();
                return new BSObject(null);
            }, 0));
            m_Properties["Clone"] = new BSFunctionReference(new BSFunction("function Clone()", a => new BSWrapperObject_System_Object(m_InternalObject.Clone()), 0));
            m_Properties["Contains"] = new BSFunctionReference(new BSFunction("function Contains(key)", a => m_InternalObject.Contains(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ContainsKey"] = new BSFunctionReference(new BSFunction("function ContainsKey(key)", a => m_InternalObject.ContainsKey(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ContainsValue"] = new BSFunctionReference(new BSFunction("function ContainsValue(value)", a => m_InternalObject.ContainsValue(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["CopyTo"] = new BSFunctionReference(new BSFunction("function CopyTo(array, arrayIndex)", a => {
                m_InternalObject.CopyTo(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetEnumerator"] = new BSFunctionReference(new BSFunction("function GetEnumerator()", a => new BSWrapperObject_System_Collections_IDictionaryEnumerator(m_InternalObject.GetEnumerator()), 0));
            m_Properties["Remove"] = new BSFunctionReference(new BSFunction("function Remove(key)", a => {
                m_InternalObject.Remove(WrapperHelper.UnwrapObject<System.Object>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetObjectData"] = new BSFunctionReference(new BSFunction("function GetObjectData(info, context)", a => {
                m_InternalObject.GetObjectData(WrapperHelper.UnwrapObject<System.Runtime.Serialization.SerializationInfo>(a[0]), WrapperHelper.UnwrapObject<System.Runtime.Serialization.StreamingContext>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["OnDeserialization"] = new BSFunctionReference(new BSFunction("function OnDeserialization(sender)", a => {
                m_InternalObject.OnDeserialization(WrapperHelper.UnwrapObject<System.Object>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
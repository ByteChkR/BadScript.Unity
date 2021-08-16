using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Array : BSWrapperObject<System.Array>

    {
        public BSWrapperObject_System_Array(System.Array obj) : base(obj)
        {
            m_Properties["LongLength"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.LongLength), null);
            m_Properties["IsFixedSize"] = new BSReflectionReference(() => m_InternalObject.IsFixedSize ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsReadOnly"] = new BSReflectionReference(() => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsSynchronized"] = new BSReflectionReference(() => m_InternalObject.IsSynchronized ? BSObject.One : BSObject.Zero, null);
            m_Properties["SyncRoot"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.SyncRoot), null);
            m_Properties["Length"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Length), null);
            m_Properties["Rank"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Rank), null);
            m_Properties["CopyTo"] = new BSFunctionReference(new BSFunction("function CopyTo(array, index)", a => {
                m_InternalObject.CopyTo(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Clone"] = new BSFunctionReference(new BSFunction("function Clone()", a => new BSWrapperObject_System_Object(m_InternalObject.Clone()), 0));
            m_Properties["CopyTo"] = new BSFunctionReference(new BSFunction("function CopyTo(array, index)", a => {
                m_InternalObject.CopyTo(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetLongLength"] = new BSFunctionReference(new BSFunction("function GetLongLength(dimension)", a => new BSObject((decimal)m_InternalObject.GetLongLength(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetValue"] = new BSFunctionReference(new BSFunction("function GetValue(index)", a => new BSWrapperObject_System_Object(m_InternalObject.GetValue(WrapperHelper.UnwrapObject<System.Int64>(a[0]))), 1));
            m_Properties["GetValue"] = new BSFunctionReference(new BSFunction("function GetValue(index1, index2)", a => new BSWrapperObject_System_Object(m_InternalObject.GetValue(WrapperHelper.UnwrapObject<System.Int64>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]))), 2));
            m_Properties["GetValue"] = new BSFunctionReference(new BSFunction("function GetValue(index1, index2, index3)", a => new BSWrapperObject_System_Object(m_InternalObject.GetValue(WrapperHelper.UnwrapObject<System.Int64>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]), WrapperHelper.UnwrapObject<System.Int64>(a[2]))), 3));
            m_Properties["SetValue"] = new BSFunctionReference(new BSFunction("function SetValue(value, index)", a => {
                m_InternalObject.SetValue(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetValue"] = new BSFunctionReference(new BSFunction("function SetValue(value, index1, index2)", a => {
                m_InternalObject.SetValue(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]), WrapperHelper.UnwrapObject<System.Int64>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetValue"] = new BSFunctionReference(new BSFunction("function SetValue(value, index1, index2, index3)", a => {
                m_InternalObject.SetValue(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]), WrapperHelper.UnwrapObject<System.Int64>(a[2]), WrapperHelper.UnwrapObject<System.Int64>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["GetEnumerator"] = new BSFunctionReference(new BSFunction("function GetEnumerator()", a => new BSWrapperObject_System_Collections_IEnumerator(m_InternalObject.GetEnumerator()), 0));
            m_Properties["GetLength"] = new BSFunctionReference(new BSFunction("function GetLength(dimension)", a => new BSObject((decimal)m_InternalObject.GetLength(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetLowerBound"] = new BSFunctionReference(new BSFunction("function GetLowerBound(dimension)", a => new BSObject((decimal)m_InternalObject.GetLowerBound(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetUpperBound"] = new BSFunctionReference(new BSFunction("function GetUpperBound(dimension)", a => new BSObject((decimal)m_InternalObject.GetUpperBound(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetValue"] = new BSFunctionReference(new BSFunction("function GetValue(index)", a => new BSWrapperObject_System_Object(m_InternalObject.GetValue(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetValue"] = new BSFunctionReference(new BSFunction("function GetValue(index1, index2)", a => new BSWrapperObject_System_Object(m_InternalObject.GetValue(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["GetValue"] = new BSFunctionReference(new BSFunction("function GetValue(index1, index2, index3)", a => new BSWrapperObject_System_Object(m_InternalObject.GetValue(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_Properties["SetValue"] = new BSFunctionReference(new BSFunction("function SetValue(value, index)", a => {
                m_InternalObject.SetValue(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetValue"] = new BSFunctionReference(new BSFunction("function SetValue(value, index1, index2)", a => {
                m_InternalObject.SetValue(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetValue"] = new BSFunctionReference(new BSFunction("function SetValue(value, index1, index2, index3)", a => {
                m_InternalObject.SetValue(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["Initialize"] = new BSFunctionReference(new BSFunction("function Initialize()", a => {
                m_InternalObject.Initialize();
                return new BSObject(null);
            }, 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
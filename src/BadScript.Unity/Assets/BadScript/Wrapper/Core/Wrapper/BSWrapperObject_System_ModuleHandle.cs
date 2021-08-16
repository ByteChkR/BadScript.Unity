using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_ModuleHandle : BSWrapperObject<System.ModuleHandle>

    {
        public BSWrapperObject_System_ModuleHandle(System.ModuleHandle obj) : base(obj)
        {
            m_Properties["MDStreamVersion"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.MDStreamVersion), null);
            m_Properties["ResolveFieldHandle"] = new BSFunctionReference(new BSFunction("function ResolveFieldHandle(fieldToken)", a => new BSWrapperObject_System_RuntimeFieldHandle(m_InternalObject.ResolveFieldHandle(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["ResolveMethodHandle"] = new BSFunctionReference(new BSFunction("function ResolveMethodHandle(methodToken)", a => new BSWrapperObject_System_RuntimeMethodHandle(m_InternalObject.ResolveMethodHandle(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["ResolveTypeHandle"] = new BSFunctionReference(new BSFunction("function ResolveTypeHandle(typeToken)", a => new BSWrapperObject_System_RuntimeTypeHandle(m_InternalObject.ResolveTypeHandle(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetRuntimeFieldHandleFromMetadataToken"] = new BSFunctionReference(new BSFunction("function GetRuntimeFieldHandleFromMetadataToken(fieldToken)", a => new BSWrapperObject_System_RuntimeFieldHandle(m_InternalObject.GetRuntimeFieldHandleFromMetadataToken(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetRuntimeMethodHandleFromMetadataToken"] = new BSFunctionReference(new BSFunction("function GetRuntimeMethodHandleFromMetadataToken(methodToken)", a => new BSWrapperObject_System_RuntimeMethodHandle(m_InternalObject.GetRuntimeMethodHandleFromMetadataToken(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetRuntimeTypeHandleFromMetadataToken"] = new BSFunctionReference(new BSFunction("function GetRuntimeTypeHandleFromMetadataToken(typeToken)", a => new BSWrapperObject_System_RuntimeTypeHandle(m_InternalObject.GetRuntimeTypeHandleFromMetadataToken(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(handle)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.ModuleHandle>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
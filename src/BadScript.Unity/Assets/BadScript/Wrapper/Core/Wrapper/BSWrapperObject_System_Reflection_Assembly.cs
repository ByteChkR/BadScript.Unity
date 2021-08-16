using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Reflection_Assembly : BSWrapperObject<System.Reflection.Assembly>

    {
        public BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly obj) : base(obj)
        {
            m_Properties["CodeBase"] = new BSReflectionReference(() => new BSObject(m_InternalObject.CodeBase), null);
            m_Properties["EscapedCodeBase"] = new BSReflectionReference(() => new BSObject(m_InternalObject.EscapedCodeBase), null);
            m_Properties["FullName"] = new BSReflectionReference(() => new BSObject(m_InternalObject.FullName), null);
            m_Properties["EntryPoint"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_MethodInfo(m_InternalObject.EntryPoint), null);
            m_Properties["Location"] = new BSReflectionReference(() => new BSObject(m_InternalObject.Location), null);
            m_Properties["ImageRuntimeVersion"] = new BSReflectionReference(() => new BSObject(m_InternalObject.ImageRuntimeVersion), null);
            m_Properties["HostContext"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.HostContext), null);
            m_Properties["ReflectionOnly"] = new BSReflectionReference(() => m_InternalObject.ReflectionOnly ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsFullyTrusted"] = new BSReflectionReference(() => m_InternalObject.IsFullyTrusted ? BSObject.One : BSObject.Zero, null);
            m_Properties["ManifestModule"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_Module(m_InternalObject.ManifestModule), null);
            m_Properties["GlobalAssemblyCache"] = new BSReflectionReference(() => m_InternalObject.GlobalAssemblyCache ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsDynamic"] = new BSReflectionReference(() => m_InternalObject.IsDynamic ? BSObject.One : BSObject.Zero, null);
            m_Properties["GetObjectData"] = new BSFunctionReference(new BSFunction("function GetObjectData(info, context)", a => {
                m_InternalObject.GetObjectData(WrapperHelper.UnwrapObject<System.Runtime.Serialization.SerializationInfo>(a[0]), WrapperHelper.UnwrapObject<System.Runtime.Serialization.StreamingContext>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetFile"] = new BSFunctionReference(new BSFunction("function GetFile(name)", a => new BSWrapperObject_System_IO_FileStream(m_InternalObject.GetFile(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["GetManifestResourceStream"] = new BSFunctionReference(new BSFunction("function GetManifestResourceStream(name)", a => new BSWrapperObject_System_IO_Stream(m_InternalObject.GetManifestResourceStream(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["GetName"] = new BSFunctionReference(new BSFunction("function GetName(copiedName)", a => new BSWrapperObject_System_Reflection_AssemblyName(m_InternalObject.GetName(WrapperHelper.UnwrapObject<System.Boolean>(a[0]))), 1));
            m_Properties["GetName"] = new BSFunctionReference(new BSFunction("function GetName()", a => new BSWrapperObject_System_Reflection_AssemblyName(m_InternalObject.GetName()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["CreateInstance"] = new BSFunctionReference(new BSFunction("function CreateInstance(typeName)", a => new BSWrapperObject_System_Object(m_InternalObject.CreateInstance(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["CreateInstance"] = new BSFunctionReference(new BSFunction("function CreateInstance(typeName, ignoreCase)", a => new BSWrapperObject_System_Object(m_InternalObject.CreateInstance(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]))), 2));
            m_Properties["GetManifestResourceInfo"] = new BSFunctionReference(new BSFunction("function GetManifestResourceInfo(resourceName)", a => new BSWrapperObject_System_Reflection_ManifestResourceInfo(m_InternalObject.GetManifestResourceInfo(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(o)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetModule"] = new BSFunctionReference(new BSFunction("function GetModule(name)", a => new BSWrapperObject_System_Reflection_Module(m_InternalObject.GetModule(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["GetSatelliteAssembly"] = new BSFunctionReference(new BSFunction("function GetSatelliteAssembly(culture)", a => new BSWrapperObject_System_Reflection_Assembly(m_InternalObject.GetSatelliteAssembly(WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(a[0]))), 1));
            m_Properties["GetSatelliteAssembly"] = new BSFunctionReference(new BSFunction("function GetSatelliteAssembly(culture, version)", a => new BSWrapperObject_System_Reflection_Assembly(m_InternalObject.GetSatelliteAssembly(WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(a[0]), WrapperHelper.UnwrapObject<System.Version>(a[1]))), 2));

        }
    }

}
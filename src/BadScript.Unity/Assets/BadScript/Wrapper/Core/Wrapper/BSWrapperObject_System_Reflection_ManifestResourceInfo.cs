using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Reflection_ManifestResourceInfo : BSWrapperObject<System.Reflection.ManifestResourceInfo>

    {
        public BSWrapperObject_System_Reflection_ManifestResourceInfo(System.Reflection.ManifestResourceInfo obj) : base(obj)
        {
            m_Properties["ReferencedAssembly"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_Assembly(m_InternalObject.ReferencedAssembly), null);
            m_Properties["FileName"] = new BSReflectionReference(() => new BSObject(m_InternalObject.FileName), null);
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
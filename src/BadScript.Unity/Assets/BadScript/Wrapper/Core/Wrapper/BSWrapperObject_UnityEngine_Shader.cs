using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Shader : BSWrapperObject<UnityEngine.Shader>

    {
        public BSWrapperObject_UnityEngine_Shader(UnityEngine.Shader obj) : base(obj)
        {
            m_Properties["maximumLOD"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.maximumLOD), x=> m_InternalObject.maximumLOD = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["isSupported"] = new BSReflectionReference(() => m_InternalObject.isSupported ? BSObject.One : BSObject.Zero, null);
            m_Properties["renderQueue"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.renderQueue), null);
            m_Properties["passCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.passCount), null);
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["GetDependency"] = new BSFunctionReference(new BSFunction("function GetDependency(name)", a => new BSWrapperObject_UnityEngine_Shader(m_InternalObject.GetDependency(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["FindPassTagValue"] = new BSFunctionReference(new BSFunction("function FindPassTagValue(passIndex, tagName)", a => new BSWrapperObject_UnityEngine_Rendering_ShaderTagId(m_InternalObject.FindPassTagValue(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Rendering.ShaderTagId>(a[1]))), 2));
            m_Properties["GetPropertyCount"] = new BSFunctionReference(new BSFunction("function GetPropertyCount()", a => new BSObject((decimal)m_InternalObject.GetPropertyCount()), 0));
            m_Properties["FindPropertyIndex"] = new BSFunctionReference(new BSFunction("function FindPropertyIndex(propertyName)", a => new BSObject((decimal)m_InternalObject.FindPropertyIndex(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["GetPropertyName"] = new BSFunctionReference(new BSFunction("function GetPropertyName(propertyIndex)", a => new BSObject(m_InternalObject.GetPropertyName(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetPropertyNameId"] = new BSFunctionReference(new BSFunction("function GetPropertyNameId(propertyIndex)", a => new BSObject((decimal)m_InternalObject.GetPropertyNameId(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetPropertyDescription"] = new BSFunctionReference(new BSFunction("function GetPropertyDescription(propertyIndex)", a => new BSObject(m_InternalObject.GetPropertyDescription(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetPropertyDefaultFloatValue"] = new BSFunctionReference(new BSFunction("function GetPropertyDefaultFloatValue(propertyIndex)", a => new BSObject((decimal)m_InternalObject.GetPropertyDefaultFloatValue(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetPropertyDefaultVectorValue"] = new BSFunctionReference(new BSFunction("function GetPropertyDefaultVectorValue(propertyIndex)", a => new BSWrapperObject_UnityEngine_Vector4(m_InternalObject.GetPropertyDefaultVectorValue(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetPropertyRangeLimits"] = new BSFunctionReference(new BSFunction("function GetPropertyRangeLimits(propertyIndex)", a => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.GetPropertyRangeLimits(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetPropertyTextureDefaultName"] = new BSFunctionReference(new BSFunction("function GetPropertyTextureDefaultName(propertyIndex)", a => new BSObject(m_InternalObject.GetPropertyTextureDefaultName(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Font : BSWrapperObject<UnityEngine.Font>

    {
        public BSWrapperObject_UnityEngine_Font(UnityEngine.Font obj) : base(obj)
        {
            m_Properties["material"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Material(m_InternalObject.material), x=> m_InternalObject.material = WrapperHelper.UnwrapObject<UnityEngine.Material>(x));
            m_Properties["dynamic"] = new BSReflectionReference(() => m_InternalObject.dynamic ? BSObject.One : BSObject.Zero, null);
            m_Properties["ascent"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.ascent), null);
            m_Properties["fontSize"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.fontSize), null);
            m_Properties["lineHeight"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.lineHeight), null);
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["HasCharacter"] = new BSFunctionReference(new BSFunction("function HasCharacter(c)", a => m_InternalObject.HasCharacter(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["RequestCharactersInTexture"] = new BSFunctionReference(new BSFunction("function RequestCharactersInTexture(characters, size)", a => {
                m_InternalObject.RequestCharactersInTexture(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["RequestCharactersInTexture"] = new BSFunctionReference(new BSFunction("function RequestCharactersInTexture(characters)", a => {
                m_InternalObject.RequestCharactersInTexture(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
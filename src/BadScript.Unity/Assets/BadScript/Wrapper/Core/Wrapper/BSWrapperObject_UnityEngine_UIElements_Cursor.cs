using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_Cursor : BSWrapperObject<UnityEngine.UIElements.Cursor>

    {
        public BSWrapperObject_UnityEngine_UIElements_Cursor(UnityEngine.UIElements.Cursor obj) : base(obj)
        {
            m_Properties["texture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(m_InternalObject.texture), x=> m_InternalObject.texture = WrapperHelper.UnwrapObject<UnityEngine.Texture2D>(x));
            m_Properties["hotspot"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.hotspot), x=> m_InternalObject.hotspot = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.UIElements.Cursor>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
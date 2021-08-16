using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_TouchScreenKeyboard : BSWrapperObject<UnityEngine.TouchScreenKeyboard>

    {
        public BSWrapperObject_UnityEngine_TouchScreenKeyboard(UnityEngine.TouchScreenKeyboard obj) : base(obj)
        {
            m_Properties["text"] = new BSReflectionReference(() => new BSObject(m_InternalObject.text), x=> m_InternalObject.text = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["active"] = new BSReflectionReference(() => m_InternalObject.active ? BSObject.One : BSObject.Zero, x=> m_InternalObject.active = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["done"] = new BSReflectionReference(() => m_InternalObject.done ? BSObject.One : BSObject.Zero, null);
            m_Properties["wasCanceled"] = new BSReflectionReference(() => m_InternalObject.wasCanceled ? BSObject.One : BSObject.Zero, null);
            m_Properties["characterLimit"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.characterLimit), x=> m_InternalObject.characterLimit = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["canGetSelection"] = new BSReflectionReference(() => m_InternalObject.canGetSelection ? BSObject.One : BSObject.Zero, null);
            m_Properties["canSetSelection"] = new BSReflectionReference(() => m_InternalObject.canSetSelection ? BSObject.One : BSObject.Zero, null);
            m_Properties["selection"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_RangeInt(m_InternalObject.selection), x=> m_InternalObject.selection = WrapperHelper.UnwrapObject<UnityEngine.RangeInt>(x));
            m_Properties["targetDisplay"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.targetDisplay), x=> m_InternalObject.targetDisplay = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
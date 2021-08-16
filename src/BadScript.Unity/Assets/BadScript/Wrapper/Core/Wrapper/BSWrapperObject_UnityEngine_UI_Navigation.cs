using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UI_Navigation : BSWrapperObject<UnityEngine.UI.Navigation>

    {
        public BSWrapperObject_UnityEngine_UI_Navigation(UnityEngine.UI.Navigation obj) : base(obj)
        {
            m_Properties["wrapAround"] = new BSReflectionReference(() => m_InternalObject.wrapAround ? BSObject.One : BSObject.Zero, x=> m_InternalObject.wrapAround = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["selectOnUp"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UI_Selectable(m_InternalObject.selectOnUp), x=> m_InternalObject.selectOnUp = WrapperHelper.UnwrapObject<UnityEngine.UI.Selectable>(x));
            m_Properties["selectOnDown"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UI_Selectable(m_InternalObject.selectOnDown), x=> m_InternalObject.selectOnDown = WrapperHelper.UnwrapObject<UnityEngine.UI.Selectable>(x));
            m_Properties["selectOnLeft"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UI_Selectable(m_InternalObject.selectOnLeft), x=> m_InternalObject.selectOnLeft = WrapperHelper.UnwrapObject<UnityEngine.UI.Selectable>(x));
            m_Properties["selectOnRight"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UI_Selectable(m_InternalObject.selectOnRight), x=> m_InternalObject.selectOnRight = WrapperHelper.UnwrapObject<UnityEngine.UI.Selectable>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.UI.Navigation>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
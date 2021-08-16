using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier : BSWrapperObject<UnityEngine.Rendering.RenderTargetIdentifier>

    {
        public BSWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier(UnityEngine.Rendering.RenderTargetIdentifier obj) : base(obj)
        {
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(rhs)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Rendering.RenderTargetIdentifier>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));

        }
    }

}
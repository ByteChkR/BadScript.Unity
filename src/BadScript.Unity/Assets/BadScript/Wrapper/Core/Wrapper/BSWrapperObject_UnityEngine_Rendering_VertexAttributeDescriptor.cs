using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor : BSWrapperObject<UnityEngine.Rendering.VertexAttributeDescriptor>

    {
        public BSWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor(UnityEngine.Rendering.VertexAttributeDescriptor obj) : base(obj)
        {
            m_Properties["dimension"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.dimension), x=> m_InternalObject.dimension = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["stream"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.stream), x=> m_InternalObject.stream = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Rendering.VertexAttributeDescriptor>(a[0])) ? BSObject.One : BSObject.Zero, 1));

        }
    }

}
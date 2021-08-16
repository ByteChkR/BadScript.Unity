using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Rendering_SubMeshDescriptor : BSWrapperObject<UnityEngine.Rendering.SubMeshDescriptor>

    {
        public BSWrapperObject_UnityEngine_Rendering_SubMeshDescriptor(UnityEngine.Rendering.SubMeshDescriptor obj) : base(obj)
        {
            m_Properties["bounds"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Bounds(m_InternalObject.bounds), x=> m_InternalObject.bounds = WrapperHelper.UnwrapObject<UnityEngine.Bounds>(x));
            m_Properties["indexStart"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.indexStart), x=> m_InternalObject.indexStart = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["indexCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.indexCount), x=> m_InternalObject.indexCount = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["baseVertex"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.baseVertex), x=> m_InternalObject.baseVertex = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["firstVertex"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.firstVertex), x=> m_InternalObject.firstVertex = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["vertexCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.vertexCount), x=> m_InternalObject.vertexCount = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));

        }
    }

}
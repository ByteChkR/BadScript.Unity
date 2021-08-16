using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure : BSWrapperObject<UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure>

    {
        public BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure obj) : base(obj)
        {
            m_Properties["Dispose"] = new BSFunctionReference(new BSFunction("function Dispose()", a => {
                m_InternalObject.Dispose();
                return new BSObject(null);
            }, 0));
            m_Properties["Release"] = new BSFunctionReference(new BSFunction("function Release()", a => {
                m_InternalObject.Release();
                return new BSObject(null);
            }, 0));
            m_Properties["Build"] = new BSFunctionReference(new BSFunction("function Build()", a => {
                m_InternalObject.Build();
                return new BSObject(null);
            }, 0));
            m_Properties["Build"] = new BSFunctionReference(new BSFunction("function Build(relativeOrigin)", a => {
                m_InternalObject.Build(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["AddInstance"] = new BSFunctionReference(new BSFunction("function AddInstance(aabbBuffer, numElements, material, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds)", a => {
                m_InternalObject.AddInstance(WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[0]), WrapperHelper.UnwrapObject<System.UInt32>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Material>(a[2]), WrapperHelper.UnwrapObject<System.Boolean>(a[3]), WrapperHelper.UnwrapObject<System.Boolean>(a[4]), WrapperHelper.UnwrapObject<System.Boolean>(a[5]), WrapperHelper.UnwrapObject<System.UInt32>(a[6]), WrapperHelper.UnwrapObject<System.Boolean>(a[7]));
                return new BSObject(null);
            }, 8));
            m_Properties["AddInstance"] = new BSFunctionReference(new BSFunction("function AddInstance(aabbBuffer, numElements, material, instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds)", a => {
                m_InternalObject.AddInstance(WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[0]), WrapperHelper.UnwrapObject<System.UInt32>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Material>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Matrix4x4>(a[3]), WrapperHelper.UnwrapObject<System.Boolean>(a[4]), WrapperHelper.UnwrapObject<System.Boolean>(a[5]), WrapperHelper.UnwrapObject<System.Boolean>(a[6]), WrapperHelper.UnwrapObject<System.UInt32>(a[7]), WrapperHelper.UnwrapObject<System.Boolean>(a[8]));
                return new BSObject(null);
            }, 9));
            m_Properties["UpdateInstanceTransform"] = new BSFunctionReference(new BSFunction("function UpdateInstanceTransform(renderer)", a => {
                m_InternalObject.UpdateInstanceTransform(WrapperHelper.UnwrapObject<UnityEngine.Renderer>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetSize"] = new BSFunctionReference(new BSFunction("function GetSize()", a => new BSObject((decimal)m_InternalObject.GetSize()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Mesh : BSWrapperObject<UnityEngine.Mesh>

    {
        public BSWrapperObject_UnityEngine_Mesh(UnityEngine.Mesh obj) : base(obj)
        {
            m_Properties["vertexBufferCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.vertexBufferCount), null);
            m_Properties["blendShapeCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.blendShapeCount), null);
            m_Properties["isReadable"] = new BSReflectionReference(() => m_InternalObject.isReadable ? BSObject.One : BSObject.Zero, null);
            m_Properties["vertexCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.vertexCount), null);
            m_Properties["subMeshCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.subMeshCount), x=> m_InternalObject.subMeshCount = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["bounds"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Bounds(m_InternalObject.bounds), x=> m_InternalObject.bounds = WrapperHelper.UnwrapObject<UnityEngine.Bounds>(x));
            m_Properties["vertexAttributeCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.vertexAttributeCount), null);
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["GetVertexAttribute"] = new BSFunctionReference(new BSFunction("function GetVertexAttribute(index)", a => new BSWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor(m_InternalObject.GetVertexAttribute(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetNativeVertexBufferPtr"] = new BSFunctionReference(new BSFunction("function GetNativeVertexBufferPtr(index)", a => new BSWrapperObject_System_IntPtr(m_InternalObject.GetNativeVertexBufferPtr(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetNativeIndexBufferPtr"] = new BSFunctionReference(new BSFunction("function GetNativeIndexBufferPtr()", a => new BSWrapperObject_System_IntPtr(m_InternalObject.GetNativeIndexBufferPtr()), 0));
            m_Properties["ClearBlendShapes"] = new BSFunctionReference(new BSFunction("function ClearBlendShapes()", a => {
                m_InternalObject.ClearBlendShapes();
                return new BSObject(null);
            }, 0));
            m_Properties["GetBlendShapeName"] = new BSFunctionReference(new BSFunction("function GetBlendShapeName(shapeIndex)", a => new BSObject(m_InternalObject.GetBlendShapeName(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetBlendShapeIndex"] = new BSFunctionReference(new BSFunction("function GetBlendShapeIndex(blendShapeName)", a => new BSObject((decimal)m_InternalObject.GetBlendShapeIndex(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["GetBlendShapeFrameCount"] = new BSFunctionReference(new BSFunction("function GetBlendShapeFrameCount(shapeIndex)", a => new BSObject((decimal)m_InternalObject.GetBlendShapeFrameCount(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetBlendShapeFrameWeight"] = new BSFunctionReference(new BSFunction("function GetBlendShapeFrameWeight(shapeIndex, frameIndex)", a => new BSObject((decimal)m_InternalObject.GetBlendShapeFrameWeight(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["GetSubMesh"] = new BSFunctionReference(new BSFunction("function GetSubMesh(index)", a => new BSWrapperObject_UnityEngine_Rendering_SubMeshDescriptor(m_InternalObject.GetSubMesh(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["MarkModified"] = new BSFunctionReference(new BSFunction("function MarkModified()", a => {
                m_InternalObject.MarkModified();
                return new BSObject(null);
            }, 0));
            m_Properties["GetUVDistributionMetric"] = new BSFunctionReference(new BSFunction("function GetUVDistributionMetric(uvSetIndex)", a => new BSObject((decimal)m_InternalObject.GetUVDistributionMetric(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetIndexStart"] = new BSFunctionReference(new BSFunction("function GetIndexStart(submesh)", a => new BSObject((decimal)m_InternalObject.GetIndexStart(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetIndexCount"] = new BSFunctionReference(new BSFunction("function GetIndexCount(submesh)", a => new BSObject((decimal)m_InternalObject.GetIndexCount(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetBaseVertex"] = new BSFunctionReference(new BSFunction("function GetBaseVertex(submesh)", a => new BSObject((decimal)m_InternalObject.GetBaseVertex(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["Clear"] = new BSFunctionReference(new BSFunction("function Clear(keepVertexLayout)", a => {
                m_InternalObject.Clear(WrapperHelper.UnwrapObject<System.Boolean>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Clear"] = new BSFunctionReference(new BSFunction("function Clear()", a => {
                m_InternalObject.Clear();
                return new BSObject(null);
            }, 0));
            m_Properties["RecalculateBounds"] = new BSFunctionReference(new BSFunction("function RecalculateBounds()", a => {
                m_InternalObject.RecalculateBounds();
                return new BSObject(null);
            }, 0));
            m_Properties["RecalculateNormals"] = new BSFunctionReference(new BSFunction("function RecalculateNormals()", a => {
                m_InternalObject.RecalculateNormals();
                return new BSObject(null);
            }, 0));
            m_Properties["RecalculateTangents"] = new BSFunctionReference(new BSFunction("function RecalculateTangents()", a => {
                m_InternalObject.RecalculateTangents();
                return new BSObject(null);
            }, 0));
            m_Properties["RecalculateUVDistributionMetric"] = new BSFunctionReference(new BSFunction("function RecalculateUVDistributionMetric(uvSetIndex, uvAreaThreshold)", a => {
                m_InternalObject.RecalculateUVDistributionMetric(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["RecalculateUVDistributionMetrics"] = new BSFunctionReference(new BSFunction("function RecalculateUVDistributionMetrics(uvAreaThreshold)", a => {
                m_InternalObject.RecalculateUVDistributionMetrics(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["MarkDynamic"] = new BSFunctionReference(new BSFunction("function MarkDynamic()", a => {
                m_InternalObject.MarkDynamic();
                return new BSObject(null);
            }, 0));
            m_Properties["UploadMeshData"] = new BSFunctionReference(new BSFunction("function UploadMeshData(markNoLongerReadable)", a => {
                m_InternalObject.UploadMeshData(WrapperHelper.UnwrapObject<System.Boolean>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Optimize"] = new BSFunctionReference(new BSFunction("function Optimize()", a => {
                m_InternalObject.Optimize();
                return new BSObject(null);
            }, 0));
            m_Properties["OptimizeIndexBuffers"] = new BSFunctionReference(new BSFunction("function OptimizeIndexBuffers()", a => {
                m_InternalObject.OptimizeIndexBuffers();
                return new BSObject(null);
            }, 0));
            m_Properties["OptimizeReorderVertexBuffer"] = new BSFunctionReference(new BSFunction("function OptimizeReorderVertexBuffer()", a => {
                m_InternalObject.OptimizeReorderVertexBuffer();
                return new BSObject(null);
            }, 0));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
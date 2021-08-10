using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Mesh : BSWrapperObject < Mesh >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Mesh( Mesh obj ) : base( obj )
        {
            m_Properties["vertexBufferCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexBufferCount ),
                null );

            m_Properties["blendShapeCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.blendShapeCount ),
                null );

            m_Properties["isReadable"] = new BSReflectionReference(
                () => m_InternalObject.isReadable ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                null );

            m_Properties["subMeshCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.subMeshCount ),
                x => m_InternalObject.subMeshCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                x => m_InternalObject.bounds = WrapperHelper.UnwrapObject < Bounds >( x ) );

            m_Properties["vertexAttributeCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexAttributeCount ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetVertexAttribute"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVertexAttribute(index)",
                    a => new BSWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor(
                        m_InternalObject.GetVertexAttribute( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetNativeVertexBufferPtr"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNativeVertexBufferPtr(index)",
                    a => new BSWrapperObject_System_IntPtr(
                        m_InternalObject.GetNativeVertexBufferPtr( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBlendShapeName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeName(shapeIndex)",
                    a => new BSObject(
                        m_InternalObject.GetBlendShapeName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBlendShapeIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeIndex(blendShapeName)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBlendShapeIndex(
                            WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBlendShapeFrameCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeFrameCount(shapeIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBlendShapeFrameCount(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBlendShapeFrameWeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBlendShapeFrameWeight(shapeIndex, frameIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBlendShapeFrameWeight(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetSubMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSubMesh(index)",
                    a => new BSWrapperObject_UnityEngine_Rendering_SubMeshDescriptor(
                        m_InternalObject.GetSubMesh( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUVDistributionMetric"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUVDistributionMetric(uvSetIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUVDistributionMetric(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetIndexStart"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIndexStart(submesh)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetIndexStart( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetIndexCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIndexCount(submesh)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetIndexCount( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBaseVertex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBaseVertex(submesh)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetBaseVertex( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

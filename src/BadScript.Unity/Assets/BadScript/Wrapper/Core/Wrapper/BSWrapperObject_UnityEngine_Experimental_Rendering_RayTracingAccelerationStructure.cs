using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class
        BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure : BSWrapperObject <
            RayTracingAccelerationStructure >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure(
            RayTracingAccelerationStructure obj ) : base( obj )
        {
            m_Properties["Dispose"] = new BSFunctionReference(
                new BSFunction(
                    "function Dispose()",
                    a =>
                    {
                        m_InternalObject.Dispose();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Release"] = new BSFunctionReference(
                new BSFunction(
                    "function Release()",
                    a =>
                    {
                        m_InternalObject.Release();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Build"] = new BSFunctionReference(
                new BSFunction(
                    "function Build()",
                    a =>
                    {
                        m_InternalObject.Build();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Build"] = new BSFunctionReference(
                new BSFunction(
                    "function Build(relativeOrigin)",
                    a =>
                    {
                        m_InternalObject.Build( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["AddInstance"] = new BSFunctionReference(
                new BSFunction(
                    "function AddInstance(aabbBuffer, numElements, material, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds)",
                    a =>
                    {
                        m_InternalObject.AddInstance(
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < bool >( a[3] ),
                            WrapperHelper.UnwrapObject < bool >( a[4] ),
                            WrapperHelper.UnwrapObject < bool >( a[5] ),
                            WrapperHelper.UnwrapObject < uint >( a[6] ),
                            WrapperHelper.UnwrapObject < bool >( a[7] ) );

                        return new BSObject( null );
                    },
                    8 ) );

            m_Properties["AddInstance"] = new BSFunctionReference(
                new BSFunction(
                    "function AddInstance(aabbBuffer, numElements, material, instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds)",
                    a =>
                    {
                        m_InternalObject.AddInstance(
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[3] ),
                            WrapperHelper.UnwrapObject < bool >( a[4] ),
                            WrapperHelper.UnwrapObject < bool >( a[5] ),
                            WrapperHelper.UnwrapObject < bool >( a[6] ),
                            WrapperHelper.UnwrapObject < uint >( a[7] ),
                            WrapperHelper.UnwrapObject < bool >( a[8] ) );

                        return new BSObject( null );
                    },
                    9 ) );

            m_Properties["UpdateInstanceTransform"] = new BSFunctionReference(
                new BSFunction(
                    "function UpdateInstanceTransform(renderer)",
                    a =>
                    {
                        m_InternalObject.UpdateInstanceTransform( WrapperHelper.UnwrapObject < Renderer >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetSize"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSize()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetSize() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}

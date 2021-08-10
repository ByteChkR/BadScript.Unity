using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_SubMeshDescriptor : BSWrapperObject < SubMeshDescriptor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_SubMeshDescriptor( SubMeshDescriptor obj ) : base( obj )
        {
            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                x => m_InternalObject.bounds = WrapperHelper.UnwrapObject < Bounds >( x ) );

            m_Properties["indexStart"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indexStart ),
                x => m_InternalObject.indexStart = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["indexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indexCount ),
                x => m_InternalObject.indexCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["baseVertex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.baseVertex ),
                x => m_InternalObject.baseVertex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["firstVertex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.firstVertex ),
                x => m_InternalObject.firstVertex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                x => m_InternalObject.vertexCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

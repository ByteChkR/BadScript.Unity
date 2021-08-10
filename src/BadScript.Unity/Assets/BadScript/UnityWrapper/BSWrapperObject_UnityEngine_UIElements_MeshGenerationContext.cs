using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_MeshGenerationContext : BSWrapperObject < MeshGenerationContext >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_MeshGenerationContext( MeshGenerationContext obj ) : base( obj )
        {
            m_Properties["visualElement"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VisualElement( m_InternalObject.visualElement ),
                null );

            m_Properties["Allocate"] = new BSFunctionReference(
                new BSFunction(
                    "function Allocate(vertexCount, indexCount, texture)",
                    a => new BSWrapperObject_UnityEngine_UIElements_MeshWriteData(
                        m_InternalObject.Allocate(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Texture >( a[2] ) ) ),
                    3 ) );

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

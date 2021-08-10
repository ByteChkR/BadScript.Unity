using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor : BSWrapperObject < VertexAttributeDescriptor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor( VertexAttributeDescriptor obj ) : base(
            obj )
        {
            m_Properties["dimension"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dimension ),
                x => m_InternalObject.dimension = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["stream"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stream ),
                x => m_InternalObject.stream = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < VertexAttributeDescriptor >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

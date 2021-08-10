using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Rendering_AsyncGPUReadbackRequest : BSWrapperObject < AsyncGPUReadbackRequest >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_AsyncGPUReadbackRequest( AsyncGPUReadbackRequest obj ) : base(
            obj )
        {
            m_Properties["done"] = new BSReflectionReference(
                () => m_InternalObject.done ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hasError"] = new BSReflectionReference(
                () => m_InternalObject.hasError ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["layerCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layerCount ),
                null );

            m_Properties["layerDataSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layerDataSize ),
                null );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                null );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                null );

            m_Properties["depth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.depth ),
                null );

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

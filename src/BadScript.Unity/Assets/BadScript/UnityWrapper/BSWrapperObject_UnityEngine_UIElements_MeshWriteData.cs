using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_MeshWriteData : BSWrapperObject < MeshWriteData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_MeshWriteData( MeshWriteData obj ) : base( obj )
        {
            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                null );

            m_Properties["indexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indexCount ),
                null );

            m_Properties["uvRegion"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.uvRegion ),
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

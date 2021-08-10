using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_BatchCullingContext : BSWrapperObject < BatchCullingContext >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_BatchCullingContext( BatchCullingContext obj ) : base( obj )
        {
            m_Properties["lodParameters"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_LODParameters( m_InternalObject.lodParameters ),
                null );

            m_Properties["cullingMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.cullingMatrix ),
                null );

            m_Properties["nearPlane"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.nearPlane ),
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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_CullingResults : BSWrapperObject < CullingResults >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_CullingResults( CullingResults obj ) : base( obj )
        {
            m_Properties["lightIndexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightIndexCount ),
                null );

            m_Properties["reflectionProbeIndexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.reflectionProbeIndexCount ),
                null );

            m_Properties["lightAndReflectionProbeIndexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightAndReflectionProbeIndexCount ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < CullingResults >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Display : BSWrapperObject < Display >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Display( Display obj ) : base( obj )
        {
            m_Properties["renderingWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.renderingWidth ),
                null );

            m_Properties["renderingHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.renderingHeight ),
                null );

            m_Properties["systemWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.systemWidth ),
                null );

            m_Properties["systemHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.systemHeight ),
                null );

            m_Properties["colorBuffer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderBuffer( m_InternalObject.colorBuffer ),
                null );

            m_Properties["depthBuffer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderBuffer( m_InternalObject.depthBuffer ),
                null );

            m_Properties["active"] = new BSReflectionReference(
                () => m_InternalObject.active ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["requiresBlitToBackbuffer"] = new BSReflectionReference(
                () => m_InternalObject.requiresBlitToBackbuffer ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["requiresSrgbBlitToBackbuffer"] = new BSReflectionReference(
                () => m_InternalObject.requiresSrgbBlitToBackbuffer ? BSObject.One : BSObject.Zero,
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

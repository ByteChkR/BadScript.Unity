using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_StencilState : BSWrapperObject < StencilState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_StencilState( StencilState obj ) : base( obj )
        {
            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["readMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.readMask ),
                x => m_InternalObject.readMask = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["writeMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.writeMask ),
                x => m_InternalObject.writeMask = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < StencilState >( a[0] ) )
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

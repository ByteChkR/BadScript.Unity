using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_XR_XRMirrorViewBlitModeDesc : BSWrapperObject < XRMirrorViewBlitModeDesc >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_XRMirrorViewBlitModeDesc( XRMirrorViewBlitModeDesc obj ) : base( obj )
        {
            m_Properties["blitMode"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.blitMode ),
                x => m_InternalObject.blitMode = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["blitModeDesc"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.blitModeDesc ),
                x => m_InternalObject.blitModeDesc = WrapperHelper.UnwrapObject < string >( x ) );

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

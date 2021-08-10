using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_XR_XRMirrorViewBlitMode : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_XR_XRMirrorViewBlitMode() : base( typeof( XRMirrorViewBlitMode ) )
        {
            m_StaticProperties["Default"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRMirrorViewBlitMode.Default ),
                null );

            m_StaticProperties["LeftEye"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRMirrorViewBlitMode.LeftEye ),
                null );

            m_StaticProperties["RightEye"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRMirrorViewBlitMode.RightEye ),
                null );

            m_StaticProperties["SideBySide"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRMirrorViewBlitMode.SideBySide ),
                null );

            m_StaticProperties["SideBySideOcclusionMesh"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRMirrorViewBlitMode.SideBySideOcclusionMesh ),
                null );

            m_StaticProperties["Distort"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRMirrorViewBlitMode.Distort ),
                null );

            m_StaticProperties["None"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRMirrorViewBlitMode.None ),
                null );

        }

        #endregion
    }

}

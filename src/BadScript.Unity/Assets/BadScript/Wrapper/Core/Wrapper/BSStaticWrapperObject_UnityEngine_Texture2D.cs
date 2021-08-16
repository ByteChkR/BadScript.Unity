using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Texture2D : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Texture2D() : base( typeof( Texture2D ) )
        {
            m_StaticProperties["whiteTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( Texture2D.whiteTexture ),
                null );

            m_StaticProperties["blackTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( Texture2D.blackTexture ),
                null );

            m_StaticProperties["redTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( Texture2D.redTexture ),
                null );

            m_StaticProperties["grayTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( Texture2D.grayTexture ),
                null );

            m_StaticProperties["linearGrayTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( Texture2D.linearGrayTexture ),
                null );

            m_StaticProperties["normalTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( Texture2D.normalTexture ),
                null );

        }

        #endregion
    }

}

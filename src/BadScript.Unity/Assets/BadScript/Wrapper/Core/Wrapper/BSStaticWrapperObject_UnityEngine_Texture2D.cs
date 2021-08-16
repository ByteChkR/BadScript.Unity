using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Texture2D : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Texture2D() : base(typeof(UnityEngine.Texture2D))
        {
            m_StaticProperties["whiteTexture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(UnityEngine.Texture2D.whiteTexture), null);
            m_StaticProperties["blackTexture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(UnityEngine.Texture2D.blackTexture), null);
            m_StaticProperties["redTexture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(UnityEngine.Texture2D.redTexture), null);
            m_StaticProperties["grayTexture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(UnityEngine.Texture2D.grayTexture), null);
            m_StaticProperties["linearGrayTexture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(UnityEngine.Texture2D.linearGrayTexture), null);
            m_StaticProperties["normalTexture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(UnityEngine.Texture2D.normalTexture), null);

        }
    }

}
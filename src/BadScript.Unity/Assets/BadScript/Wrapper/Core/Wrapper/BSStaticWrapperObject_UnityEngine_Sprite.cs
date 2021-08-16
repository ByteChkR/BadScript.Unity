using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Sprite : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Sprite() : base(typeof(UnityEngine.Sprite))
        {
            m_StaticProperties["Create"] = new BSFunctionReference(new BSFunction("function Create(texture, rect, pivot, pixelsPerUnit, extrude)", a => new BSWrapperObject_UnityEngine_Sprite(UnityEngine.Sprite.Create(WrapperHelper.UnwrapObject<UnityEngine.Texture2D>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Rect>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector2>(a[2]), WrapperHelper.UnwrapObject<System.Single>(a[3]), WrapperHelper.UnwrapObject<System.UInt32>(a[4]))), 5));
            m_StaticProperties["Create"] = new BSFunctionReference(new BSFunction("function Create(texture, rect, pivot, pixelsPerUnit)", a => new BSWrapperObject_UnityEngine_Sprite(UnityEngine.Sprite.Create(WrapperHelper.UnwrapObject<UnityEngine.Texture2D>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Rect>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector2>(a[2]), WrapperHelper.UnwrapObject<System.Single>(a[3]))), 4));
            m_StaticProperties["Create"] = new BSFunctionReference(new BSFunction("function Create(texture, rect, pivot)", a => new BSWrapperObject_UnityEngine_Sprite(UnityEngine.Sprite.Create(WrapperHelper.UnwrapObject<UnityEngine.Texture2D>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Rect>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector2>(a[2]))), 3));

        }
    }

}
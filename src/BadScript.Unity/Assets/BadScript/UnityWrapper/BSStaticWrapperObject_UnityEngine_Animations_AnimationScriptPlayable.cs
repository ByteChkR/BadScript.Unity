using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Animations_AnimationScriptPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Animations_AnimationScriptPlayable() : base(
            typeof( AnimationScriptPlayable ) )
        {
            m_StaticProperties["Null"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Animations_AnimationScriptPlayable(
                    AnimationScriptPlayable.Null ),
                null );

        }

        #endregion
    }

}

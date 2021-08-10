using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Playables_PlayableOutputHandle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Playables_PlayableOutputHandle() : base(
            typeof( PlayableOutputHandle ) )
        {
            m_StaticProperties["Null"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Playables_PlayableOutputHandle( PlayableOutputHandle.Null ),
                null );

        }

        #endregion
    }

}

using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Playables_PlayableOutput : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Playables_PlayableOutput() : base( typeof( PlayableOutput ) )
        {
            m_StaticProperties["Null"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Playables_PlayableOutput( PlayableOutput.Null ),
                null );

        }

        #endregion
    }

}

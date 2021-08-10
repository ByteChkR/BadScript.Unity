using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Video;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Video_VideoPlayer : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Video_VideoPlayer() : base( typeof( VideoPlayer ) )
        {
            m_StaticProperties["controlledAudioTrackMaxCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) VideoPlayer.controlledAudioTrackMaxCount ),
                null );

        }

        #endregion
    }

}

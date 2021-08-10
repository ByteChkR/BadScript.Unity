using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Experimental.Video;
using UnityEngine.Video;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_Video_VideoPlayerExtensions : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_Video_VideoPlayerExtensions() : base(
            typeof( VideoPlayerExtensions ) )
        {
            m_StaticProperties["GetAudioSampleProvider"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioSampleProvider(vp, trackIndex)",
                    a => new BSWrapperObject_UnityEngine_Experimental_Audio_AudioSampleProvider(
                        VideoPlayerExtensions.GetAudioSampleProvider(
                            WrapperHelper.UnwrapObject < VideoPlayer >( a[0] ),
                            WrapperHelper.UnwrapObject < ushort >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

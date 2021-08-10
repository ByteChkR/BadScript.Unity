using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Experimental.Video;
using UnityEngine.Playables;
using UnityEngine.Video;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_Video_VideoClipPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_Video_VideoClipPlayable() : base(
            typeof( VideoClipPlayable ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, clip, looping)",
                    a => new BSWrapperObject_UnityEngine_Experimental_Video_VideoClipPlayable(
                        VideoClipPlayable.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < VideoClip >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}

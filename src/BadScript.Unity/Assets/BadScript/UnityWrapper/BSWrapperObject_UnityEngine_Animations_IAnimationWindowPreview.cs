using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Animations_IAnimationWindowPreview : BSWrapperObject < IAnimationWindowPreview >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_IAnimationWindowPreview( IAnimationWindowPreview obj ) : base(
            obj )
        {
            m_Properties["BuildPreviewGraph"] = new BSFunctionReference(
                new BSFunction(
                    "function BuildPreviewGraph(graph, inputPlayable)",
                    a => new BSWrapperObject_UnityEngine_Playables_Playable(
                        m_InternalObject.BuildPreviewGraph(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < Playable >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

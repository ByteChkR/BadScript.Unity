using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Experimental.Playables;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_Playables_CameraPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_Playables_CameraPlayable() : base(
            typeof( CameraPlayable ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, camera)",
                    a => new BSWrapperObject_UnityEngine_Experimental_Playables_CameraPlayable(
                        CameraPlayable.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < Camera >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Playables_IPlayableAsset : BSWrapperObject < IPlayableAsset >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_IPlayableAsset( IPlayableAsset obj ) : base( obj )
        {
            m_Properties["duration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.duration ),
                null );

            m_Properties["CreatePlayable"] = new BSFunctionReference(
                new BSFunction(
                    "function CreatePlayable(graph, owner)",
                    a => new BSWrapperObject_UnityEngine_Playables_Playable(
                        m_InternalObject.CreatePlayable(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < GameObject >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

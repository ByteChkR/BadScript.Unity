using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AudioListener : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AudioListener() : base( typeof( AudioListener ) )
        {
            m_StaticProperties["volume"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AudioListener.volume ),
                x => AudioListener.volume = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["pause"] = new BSReflectionReference(
                () => AudioListener.pause ? BSObject.One : BSObject.Zero,
                x => AudioListener.pause = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}

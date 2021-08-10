using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Playables_PlayableBinding : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Playables_PlayableBinding() : base( typeof( PlayableBinding ) )
        {
            //Positive Infinity Does not Cast to decimal
            //m_StaticProperties["DefaultDuration"] = new BSReflectionReference(
            //    () => new BSObject( ( decimal ) PlayableBinding.DefaultDuration ),
            //    null );

        }

        #endregion
    }

}

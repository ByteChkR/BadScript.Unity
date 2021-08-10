using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_LODGroup : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_LODGroup() : base( typeof( LODGroup ) )
        {
            m_StaticProperties["crossFadeAnimationDuration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) LODGroup.crossFadeAnimationDuration ),
                x => LODGroup.crossFadeAnimationDuration = WrapperHelper.UnwrapObject < float >( x ) );

        }

        #endregion
    }

}

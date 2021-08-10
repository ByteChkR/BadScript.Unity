using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIVertex : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIVertex() : base( typeof( UIVertex ) )
        {
            m_StaticProperties["simpleVert"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIVertex( UIVertex.simpleVert ),
                x => UIVertex.simpleVert = WrapperHelper.UnwrapObject < UIVertex >( x ) );

        }

        #endregion
    }

}

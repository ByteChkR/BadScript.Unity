using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Vertex : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Vertex() : base( typeof( Vertex ) )
        {
            m_StaticProperties["nearZ"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Vertex.nearZ ),
                null );

        }

        #endregion
    }

}

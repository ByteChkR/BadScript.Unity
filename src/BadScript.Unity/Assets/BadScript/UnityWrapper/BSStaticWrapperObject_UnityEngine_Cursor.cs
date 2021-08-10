using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Cursor : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Cursor() : base( typeof( Cursor ) )
        {
            m_StaticProperties["visible"] = new BSReflectionReference(
                () => Cursor.visible ? BSObject.One : BSObject.Zero,
                x => Cursor.visible = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}

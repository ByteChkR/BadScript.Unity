using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Length : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Length() : base( typeof( Length ) )
        {
            m_StaticProperties["Percent"] = new BSFunctionReference(
                new BSFunction(
                    "function Percent(value)",
                    a => new BSWrapperObject_UnityEngine_UIElements_Length(
                        Length.Percent( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

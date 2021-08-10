using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_PropertyName : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_PropertyName() : base( typeof( PropertyName ) )
        {
            m_StaticProperties["IsNullOrEmpty"] = new BSFunctionReference(
                new BSFunction(
                    "function IsNullOrEmpty(prop)",
                    a => PropertyName.IsNullOrEmpty( WrapperHelper.UnwrapObject < PropertyName >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

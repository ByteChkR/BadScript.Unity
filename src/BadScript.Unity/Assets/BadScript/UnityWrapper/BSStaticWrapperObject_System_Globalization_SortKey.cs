using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Globalization_SortKey : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Globalization_SortKey() : base( typeof( SortKey ) )
        {
            m_StaticProperties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(sortkey1, sortkey2)",
                    a => new BSObject(
                        ( decimal ) SortKey.Compare(
                            WrapperHelper.UnwrapObject < SortKey >( a[0] ),
                            WrapperHelper.UnwrapObject < SortKey >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

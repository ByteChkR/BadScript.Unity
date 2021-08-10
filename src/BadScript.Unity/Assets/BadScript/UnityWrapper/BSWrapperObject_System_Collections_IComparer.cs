using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Collections_IComparer : BSWrapperObject < IComparer >

    {
        #region Public

        public BSWrapperObject_System_Collections_IComparer( IComparer obj ) : base( obj )
        {
            m_Properties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(x, y)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Compare(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Collections_Hashtable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Collections_Hashtable() : base( typeof( Hashtable ) )
        {
            m_StaticProperties["Synchronized"] = new BSFunctionReference(
                new BSFunction(
                    "function Synchronized(table)",
                    a => new BSWrapperObject_System_Collections_Hashtable(
                        Hashtable.Synchronized( WrapperHelper.UnwrapObject < Hashtable >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Version : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Version() : base( typeof( Version ) )
        {
            m_StaticProperties["Parse"] = new BSFunctionReference(
                new BSFunction(
                    "function Parse(input)",
                    a => new BSWrapperObject_System_Version(
                        Version.Parse( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

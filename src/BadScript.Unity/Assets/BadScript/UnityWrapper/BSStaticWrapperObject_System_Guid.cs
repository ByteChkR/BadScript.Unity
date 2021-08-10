using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Guid : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Guid() : base( typeof( Guid ) )
        {
            m_StaticProperties["Empty"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Guid( Guid.Empty ),
                null );

            m_StaticProperties["Parse"] = new BSFunctionReference(
                new BSFunction(
                    "function Parse(input)",
                    a => new BSWrapperObject_System_Guid( Guid.Parse( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ParseExact"] = new BSFunctionReference(
                new BSFunction(
                    "function ParseExact(input, format)",
                    a => new BSWrapperObject_System_Guid(
                        Guid.ParseExact(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

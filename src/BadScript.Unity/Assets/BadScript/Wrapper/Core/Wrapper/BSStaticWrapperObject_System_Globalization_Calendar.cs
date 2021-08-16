using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_Calendar : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Globalization_Calendar() : base( typeof( Calendar ) )
        {
            m_StaticProperties["CurrentEra"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Calendar.CurrentEra ),
                null );

            m_StaticProperties["ReadOnly"] = new BSFunctionReference(
                new BSFunction(
                    "function ReadOnly(calendar)",
                    a => new BSWrapperObject_System_Globalization_Calendar(
                        Calendar.ReadOnly( WrapperHelper.UnwrapObject < Calendar >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_Calendar : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Globalization_Calendar() : base(typeof(System.Globalization.Calendar))
        {
            m_StaticProperties["CurrentEra"] = new BSReflectionReference(() => new BSObject((decimal)System.Globalization.Calendar.CurrentEra), null);
            m_StaticProperties["ReadOnly"] = new BSFunctionReference(new BSFunction("function ReadOnly(calendar)", a => new BSWrapperObject_System_Globalization_Calendar(System.Globalization.Calendar.ReadOnly(WrapperHelper.UnwrapObject<System.Globalization.Calendar>(a[0]))), 1));

        }
    }

}
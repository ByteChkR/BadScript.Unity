using System.Reflection;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_Module : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Reflection_Module() : base( typeof( Module ) )
        {
            m_StaticProperties["FilterTypeName"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_TypeFilter( Module.FilterTypeName ),
                null );

            m_StaticProperties["FilterTypeNameIgnoreCase"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_TypeFilter( Module.FilterTypeNameIgnoreCase ),
                null );

        }

        #endregion
    }

}

using System.Reflection;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Reflection_ConstructorInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Reflection_ConstructorInfo() : base( typeof( ConstructorInfo ) )
        {
            m_StaticProperties["ConstructorName"] = new BSReflectionReference(
                () => new BSObject( ConstructorInfo.ConstructorName ),
                null );

            m_StaticProperties["TypeConstructorName"] = new BSReflectionReference(
                () => new BSObject( ConstructorInfo.TypeConstructorName ),
                null );

        }

        #endregion
    }

}

using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Globalization_SortKey : BSWrapperObject < SortKey >

    {
        #region Public

        public BSWrapperObject_System_Globalization_SortKey( SortKey obj ) : base( obj )
        {
            m_Properties["OriginalString"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.OriginalString ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(value)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

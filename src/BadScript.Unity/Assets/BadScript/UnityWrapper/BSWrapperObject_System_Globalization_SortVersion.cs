using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Globalization_SortVersion : BSWrapperObject < SortVersion >

    {
        #region Public

        public BSWrapperObject_System_Globalization_SortVersion( SortVersion obj ) : base( obj )
        {
            m_Properties["FullVersion"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.FullVersion ),
                null );

            m_Properties["SortId"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Guid( m_InternalObject.SortId ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < SortVersion >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

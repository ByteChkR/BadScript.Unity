using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Collections_IEqualityComparer : BSWrapperObject < IEqualityComparer >

    {
        #region Public

        public BSWrapperObject_System_Collections_IEqualityComparer( IEqualityComparer obj ) : base( obj )
        {
            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(x, y)",
                    a => m_InternalObject.Equals(
                        WrapperHelper.UnwrapObject < object >( a[0] ),
                        WrapperHelper.UnwrapObject < object >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode(obj)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetHashCode( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

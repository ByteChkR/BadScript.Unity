using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Object : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Object() : base( typeof( object ) )
        {
            m_StaticProperties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(objA, objB)",
                    a => Equals(
                        WrapperHelper.UnwrapObject < object >( a[0] ),
                        WrapperHelper.UnwrapObject < object >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["ReferenceEquals"] = new BSFunctionReference(
                new BSFunction(
                    "function ReferenceEquals(objA, objB)",
                    a => ReferenceEquals(
                        WrapperHelper.UnwrapObject < object >( a[0] ),
                        WrapperHelper.UnwrapObject < object >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

        }

        #endregion
    }

}

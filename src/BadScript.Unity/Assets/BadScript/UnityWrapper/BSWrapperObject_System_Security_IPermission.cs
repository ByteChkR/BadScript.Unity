using System.Security;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Security_IPermission : BSWrapperObject < IPermission >

    {
        #region Public

        public BSWrapperObject_System_Security_IPermission( IPermission obj ) : base( obj )
        {
            m_Properties["Intersect"] = new BSFunctionReference(
                new BSFunction(
                    "function Intersect(target)",
                    a => new BSWrapperObject_System_Security_IPermission(
                        m_InternalObject.Intersect( WrapperHelper.UnwrapObject < IPermission >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsSubsetOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSubsetOf(target)",
                    a => m_InternalObject.IsSubsetOf( WrapperHelper.UnwrapObject < IPermission >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Union"] = new BSFunctionReference(
                new BSFunction(
                    "function Union(target)",
                    a => new BSWrapperObject_System_Security_IPermission(
                        m_InternalObject.Union( WrapperHelper.UnwrapObject < IPermission >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

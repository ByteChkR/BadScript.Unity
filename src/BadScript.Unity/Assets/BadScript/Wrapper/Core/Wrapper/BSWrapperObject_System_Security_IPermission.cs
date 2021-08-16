using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Security_IPermission : BSWrapperObject<System.Security.IPermission>

    {
        public BSWrapperObject_System_Security_IPermission(System.Security.IPermission obj) : base(obj)
        {
            m_Properties["Copy"] = new BSFunctionReference(new BSFunction("function Copy()", a => new BSWrapperObject_System_Security_IPermission(m_InternalObject.Copy()), 0));
            m_Properties["Demand"] = new BSFunctionReference(new BSFunction("function Demand()", a => {
                m_InternalObject.Demand();
                return new BSObject(null);
            }, 0));
            m_Properties["Intersect"] = new BSFunctionReference(new BSFunction("function Intersect(target)", a => new BSWrapperObject_System_Security_IPermission(m_InternalObject.Intersect(WrapperHelper.UnwrapObject<System.Security.IPermission>(a[0]))), 1));
            m_Properties["IsSubsetOf"] = new BSFunctionReference(new BSFunction("function IsSubsetOf(target)", a => m_InternalObject.IsSubsetOf(WrapperHelper.UnwrapObject<System.Security.IPermission>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Union"] = new BSFunctionReference(new BSFunction("function Union(target)", a => new BSWrapperObject_System_Security_IPermission(m_InternalObject.Union(WrapperHelper.UnwrapObject<System.Security.IPermission>(a[0]))), 1));

        }
    }

}
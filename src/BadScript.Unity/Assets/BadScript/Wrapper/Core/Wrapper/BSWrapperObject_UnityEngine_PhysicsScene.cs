using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_PhysicsScene : BSWrapperObject<UnityEngine.PhysicsScene>

    {
        public BSWrapperObject_UnityEngine_PhysicsScene(UnityEngine.PhysicsScene obj) : base(obj)
        {
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.PhysicsScene>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["IsValid"] = new BSFunctionReference(new BSFunction("function IsValid()", a => m_InternalObject.IsValid() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["IsEmpty"] = new BSFunctionReference(new BSFunction("function IsEmpty()", a => m_InternalObject.IsEmpty() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["Simulate"] = new BSFunctionReference(new BSFunction("function Simulate(step)", a => {
                m_InternalObject.Simulate(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));

        }
    }

}
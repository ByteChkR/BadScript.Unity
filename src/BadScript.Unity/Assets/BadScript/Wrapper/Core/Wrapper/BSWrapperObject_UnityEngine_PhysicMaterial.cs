using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_PhysicMaterial : BSWrapperObject<UnityEngine.PhysicMaterial>

    {
        public BSWrapperObject_UnityEngine_PhysicMaterial(UnityEngine.PhysicMaterial obj) : base(obj)
        {
            m_Properties["bounciness"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.bounciness), x=> m_InternalObject.bounciness = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["dynamicFriction"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.dynamicFriction), x=> m_InternalObject.dynamicFriction = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["staticFriction"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.staticFriction), x=> m_InternalObject.staticFriction = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["bouncyness"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.bounciness), x=> m_InternalObject.bounciness = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
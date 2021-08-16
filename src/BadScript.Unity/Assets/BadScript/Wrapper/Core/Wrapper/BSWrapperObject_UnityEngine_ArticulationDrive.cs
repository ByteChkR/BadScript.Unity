using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_ArticulationDrive : BSWrapperObject<UnityEngine.ArticulationDrive>

    {
        public BSWrapperObject_UnityEngine_ArticulationDrive(UnityEngine.ArticulationDrive obj) : base(obj)
        {
            m_Properties["lowerLimit"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.lowerLimit), x=> m_InternalObject.lowerLimit = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["upperLimit"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.upperLimit), x=> m_InternalObject.upperLimit = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["stiffness"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.stiffness), x=> m_InternalObject.stiffness = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["damping"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.damping), x=> m_InternalObject.damping = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["forceLimit"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.forceLimit), x=> m_InternalObject.forceLimit = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["target"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.target), x=> m_InternalObject.target = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["targetVelocity"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.targetVelocity), x=> m_InternalObject.targetVelocity = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
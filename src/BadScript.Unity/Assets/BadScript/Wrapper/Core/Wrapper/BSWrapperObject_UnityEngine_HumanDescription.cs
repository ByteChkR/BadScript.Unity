using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_HumanDescription : BSWrapperObject<UnityEngine.HumanDescription>

    {
        public BSWrapperObject_UnityEngine_HumanDescription(UnityEngine.HumanDescription obj) : base(obj)
        {
            m_Properties["upperArmTwist"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.upperArmTwist), x=> m_InternalObject.upperArmTwist = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["lowerArmTwist"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.lowerArmTwist), x=> m_InternalObject.lowerArmTwist = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["upperLegTwist"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.upperLegTwist), x=> m_InternalObject.upperLegTwist = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["lowerLegTwist"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.lowerLegTwist), x=> m_InternalObject.lowerLegTwist = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["armStretch"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.armStretch), x=> m_InternalObject.armStretch = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["legStretch"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.legStretch), x=> m_InternalObject.legStretch = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["feetSpacing"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.feetSpacing), x=> m_InternalObject.feetSpacing = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["hasTranslationDoF"] = new BSReflectionReference(() => m_InternalObject.hasTranslationDoF ? BSObject.One : BSObject.Zero, x=> m_InternalObject.hasTranslationDoF = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
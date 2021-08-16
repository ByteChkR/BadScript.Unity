using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Playables_PlayableGraph : BSWrapperObject<UnityEngine.Playables.PlayableGraph>

    {
        public BSWrapperObject_UnityEngine_Playables_PlayableGraph(UnityEngine.Playables.PlayableGraph obj) : base(obj)
        {
            m_Properties["GetRootPlayable"] = new BSFunctionReference(new BSFunction("function GetRootPlayable(index)", a => new BSWrapperObject_UnityEngine_Playables_Playable(m_InternalObject.GetRootPlayable(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetOutput"] = new BSFunctionReference(new BSFunction("function GetOutput(index)", a => new BSWrapperObject_UnityEngine_Playables_PlayableOutput(m_InternalObject.GetOutput(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["Evaluate"] = new BSFunctionReference(new BSFunction("function Evaluate()", a => {
                m_InternalObject.Evaluate();
                return new BSObject(null);
            }, 0));
            m_Properties["Destroy"] = new BSFunctionReference(new BSFunction("function Destroy()", a => {
                m_InternalObject.Destroy();
                return new BSObject(null);
            }, 0));
            m_Properties["IsValid"] = new BSFunctionReference(new BSFunction("function IsValid()", a => m_InternalObject.IsValid() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["IsPlaying"] = new BSFunctionReference(new BSFunction("function IsPlaying()", a => m_InternalObject.IsPlaying() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["IsDone"] = new BSFunctionReference(new BSFunction("function IsDone()", a => m_InternalObject.IsDone() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["Play"] = new BSFunctionReference(new BSFunction("function Play()", a => {
                m_InternalObject.Play();
                return new BSObject(null);
            }, 0));
            m_Properties["Stop"] = new BSFunctionReference(new BSFunction("function Stop()", a => {
                m_InternalObject.Stop();
                return new BSObject(null);
            }, 0));
            m_Properties["Evaluate"] = new BSFunctionReference(new BSFunction("function Evaluate(deltaTime)", a => {
                m_InternalObject.Evaluate(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetResolver"] = new BSFunctionReference(new BSFunction("function GetResolver()", a => new BSWrapperObject_UnityEngine_IExposedPropertyTable(m_InternalObject.GetResolver()), 0));
            m_Properties["SetResolver"] = new BSFunctionReference(new BSFunction("function SetResolver(value)", a => {
                m_InternalObject.SetResolver(WrapperHelper.UnwrapObject<UnityEngine.IExposedPropertyTable>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetPlayableCount"] = new BSFunctionReference(new BSFunction("function GetPlayableCount()", a => new BSObject((decimal)m_InternalObject.GetPlayableCount()), 0));
            m_Properties["GetRootPlayableCount"] = new BSFunctionReference(new BSFunction("function GetRootPlayableCount()", a => new BSObject((decimal)m_InternalObject.GetRootPlayableCount()), 0));
            m_Properties["GetOutputCount"] = new BSFunctionReference(new BSFunction("function GetOutputCount()", a => new BSObject((decimal)m_InternalObject.GetOutputCount()), 0));
            m_Properties["GetEditorName"] = new BSFunctionReference(new BSFunction("function GetEditorName()", a => new BSObject(m_InternalObject.GetEditorName()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
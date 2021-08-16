using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduler : BSWrapperObject<UnityEngine.UIElements.IVisualElementScheduler>

    {
        public BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduler(UnityEngine.UIElements.IVisualElementScheduler obj) : base(obj)
        {
            m_Properties["Execute"] = new BSFunctionReference(new BSFunction("function Execute(updateEvent)", a => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem(m_InternalObject.Execute(WrapperHelper.UnwrapObject<System.Action>(a[0]))), 1));

        }
    }

}
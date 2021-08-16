using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_IExposedPropertyTable : BSWrapperObject<UnityEngine.IExposedPropertyTable>

    {
        public BSWrapperObject_UnityEngine_IExposedPropertyTable(UnityEngine.IExposedPropertyTable obj) : base(obj)
        {
            m_Properties["SetReferenceValue"] = new BSFunctionReference(new BSFunction("function SetReferenceValue(id, value)", a => {
                m_InternalObject.SetReferenceValue(WrapperHelper.UnwrapObject<UnityEngine.PropertyName>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Object>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["ClearReferenceValue"] = new BSFunctionReference(new BSFunction("function ClearReferenceValue(id)", a => {
                m_InternalObject.ClearReferenceValue(WrapperHelper.UnwrapObject<UnityEngine.PropertyName>(a[0]));
                return new BSObject(null);
            }, 1));

        }
    }

}
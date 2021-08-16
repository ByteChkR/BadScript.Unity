using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_LayerMask : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_LayerMask() : base(typeof(UnityEngine.LayerMask))
        {
            m_StaticProperties["LayerToName"] = new BSFunctionReference(new BSFunction("function LayerToName(layer)", a => new BSObject(UnityEngine.LayerMask.LayerToName(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["NameToLayer"] = new BSFunctionReference(new BSFunction("function NameToLayer(layerName)", a => new BSObject((decimal)UnityEngine.LayerMask.NameToLayer(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
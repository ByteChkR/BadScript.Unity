using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Plane : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Plane() : base(typeof(UnityEngine.Plane))
        {
            m_StaticProperties["Translate"] = new BSFunctionReference(new BSFunction("function Translate(plane, translation)", a => new BSWrapperObject_UnityEngine_Plane(UnityEngine.Plane.Translate(WrapperHelper.UnwrapObject<UnityEngine.Plane>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));

        }
    }

}
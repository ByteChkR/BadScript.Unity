using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_GameObject : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_GameObject() : base(typeof(UnityEngine.GameObject))
        {
            m_StaticProperties["FindWithTag"] = new BSFunctionReference(new BSFunction("function FindWithTag(tag)", a => new BSWrapperObject_UnityEngine_GameObject(UnityEngine.GameObject.FindWithTag(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["FindGameObjectWithTag"] = new BSFunctionReference(new BSFunction("function FindGameObjectWithTag(tag)", a => new BSWrapperObject_UnityEngine_GameObject(UnityEngine.GameObject.FindGameObjectWithTag(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["Find"] = new BSFunctionReference(new BSFunction("function Find(name)", a => new BSWrapperObject_UnityEngine_GameObject(UnityEngine.GameObject.Find(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}
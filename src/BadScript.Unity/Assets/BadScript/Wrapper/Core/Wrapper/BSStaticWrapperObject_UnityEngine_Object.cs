using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Object : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Object() : base(typeof(UnityEngine.Object))
        {
            m_StaticProperties["Instantiate"] = new BSFunctionReference(new BSFunction("function Instantiate(original, position, rotation)", a => new BSWrapperObject_UnityEngine_Object(UnityEngine.Object.Instantiate(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[2]))), 3));
            m_StaticProperties["Instantiate"] = new BSFunctionReference(new BSFunction("function Instantiate(original, position, rotation, parent)", a => new BSWrapperObject_UnityEngine_Object(UnityEngine.Object.Instantiate(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[3]))), 4));
            m_StaticProperties["Instantiate"] = new BSFunctionReference(new BSFunction("function Instantiate(original)", a => new BSWrapperObject_UnityEngine_Object(UnityEngine.Object.Instantiate(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]))), 1));
            m_StaticProperties["Instantiate"] = new BSFunctionReference(new BSFunction("function Instantiate(original, parent)", a => new BSWrapperObject_UnityEngine_Object(UnityEngine.Object.Instantiate(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[1]))), 2));
            m_StaticProperties["Instantiate"] = new BSFunctionReference(new BSFunction("function Instantiate(original, parent, instantiateInWorldSpace)", a => new BSWrapperObject_UnityEngine_Object(UnityEngine.Object.Instantiate(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[1]), WrapperHelper.UnwrapObject<System.Boolean>(a[2]))), 3));
            m_StaticProperties["Destroy"] = new BSFunctionReference(new BSFunction("function Destroy(obj, t)", a => {
                UnityEngine.Object.Destroy(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["Destroy"] = new BSFunctionReference(new BSFunction("function Destroy(obj)", a => {
                UnityEngine.Object.Destroy(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["DestroyImmediate"] = new BSFunctionReference(new BSFunction("function DestroyImmediate(obj, allowDestroyingAssets)", a => {
                UnityEngine.Object.DestroyImmediate(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["DestroyImmediate"] = new BSFunctionReference(new BSFunction("function DestroyImmediate(obj)", a => {
                UnityEngine.Object.DestroyImmediate(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["DontDestroyOnLoad"] = new BSFunctionReference(new BSFunction("function DontDestroyOnLoad(target)", a => {
                UnityEngine.Object.DontDestroyOnLoad(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["DestroyObject"] = new BSFunctionReference(new BSFunction("function DestroyObject(obj, t)", a => {
                UnityEngine.Object.DestroyObject(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["DestroyObject"] = new BSFunctionReference(new BSFunction("function DestroyObject(obj)", a => {
                UnityEngine.Object.DestroyObject(WrapperHelper.UnwrapObject<UnityEngine.Object>(a[0]));
                return new BSObject(null);
            }, 1));

        }
    }

}
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_RectInt : BSWrapperObject<UnityEngine.RectInt>

    {
        public BSWrapperObject_UnityEngine_RectInt(UnityEngine.RectInt obj) : base(obj)
        {
            m_Properties["x"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.x), x=> m_InternalObject.x = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["y"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.y), x=> m_InternalObject.y = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["center"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.center), null);
            m_Properties["min"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2Int(m_InternalObject.min), x=> m_InternalObject.min = WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(x));
            m_Properties["max"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2Int(m_InternalObject.max), x=> m_InternalObject.max = WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(x));
            m_Properties["width"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.width), x=> m_InternalObject.width = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["height"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.height), x=> m_InternalObject.height = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["xMin"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.xMin), x=> m_InternalObject.xMin = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["yMin"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.yMin), x=> m_InternalObject.yMin = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["xMax"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.xMax), x=> m_InternalObject.xMax = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["yMax"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.yMax), x=> m_InternalObject.yMax = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["position"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2Int(m_InternalObject.position), x=> m_InternalObject.position = WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(x));
            m_Properties["size"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2Int(m_InternalObject.size), x=> m_InternalObject.size = WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(x));
            m_Properties["SetMinMax"] = new BSFunctionReference(new BSFunction("function SetMinMax(minPosition, maxPosition)", a => {
                m_InternalObject.SetMinMax(WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["ClampToBounds"] = new BSFunctionReference(new BSFunction("function ClampToBounds(bounds)", a => {
                m_InternalObject.ClampToBounds(WrapperHelper.UnwrapObject<UnityEngine.RectInt>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Contains"] = new BSFunctionReference(new BSFunction("function Contains(position)", a => m_InternalObject.Contains(WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Overlaps"] = new BSFunctionReference(new BSFunction("function Overlaps(other)", a => m_InternalObject.Overlaps(WrapperHelper.UnwrapObject<UnityEngine.RectInt>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.RectInt>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));

        }
    }

}
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Color : BSWrapperObject<UnityEngine.Color>

    {
        public BSWrapperObject_UnityEngine_Color(UnityEngine.Color obj) : base(obj)
        {
            m_Properties["grayscale"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.grayscale), null);
            m_Properties["linear"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.linear), null);
            m_Properties["gamma"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.gamma), null);
            m_Properties["maxColorComponent"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.maxColorComponent), null);
            m_Properties["r"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.r), x=> m_InternalObject.r = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["g"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.g), x=> m_InternalObject.g = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["b"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.b), x=> m_InternalObject.b = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["a"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.a), x=> m_InternalObject.a = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Color>(a[0])) ? BSObject.One : BSObject.Zero, 1));

        }
    }

}
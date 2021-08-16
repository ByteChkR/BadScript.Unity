using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_TextGenerationSettings : BSWrapperObject<UnityEngine.TextGenerationSettings>

    {
        public BSWrapperObject_UnityEngine_TextGenerationSettings(UnityEngine.TextGenerationSettings obj) : base(obj)
        {
            m_Properties["font"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Font(m_InternalObject.font), x=> m_InternalObject.font = WrapperHelper.UnwrapObject<UnityEngine.Font>(x));
            m_Properties["color"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.color), x=> m_InternalObject.color = WrapperHelper.UnwrapObject<UnityEngine.Color>(x));
            m_Properties["fontSize"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.fontSize), x=> m_InternalObject.fontSize = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["lineSpacing"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.lineSpacing), x=> m_InternalObject.lineSpacing = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["richText"] = new BSReflectionReference(() => m_InternalObject.richText ? BSObject.One : BSObject.Zero, x=> m_InternalObject.richText = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["scaleFactor"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.scaleFactor), x=> m_InternalObject.scaleFactor = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["alignByGeometry"] = new BSReflectionReference(() => m_InternalObject.alignByGeometry ? BSObject.One : BSObject.Zero, x=> m_InternalObject.alignByGeometry = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["resizeTextForBestFit"] = new BSReflectionReference(() => m_InternalObject.resizeTextForBestFit ? BSObject.One : BSObject.Zero, x=> m_InternalObject.resizeTextForBestFit = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["resizeTextMinSize"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.resizeTextMinSize), x=> m_InternalObject.resizeTextMinSize = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["resizeTextMaxSize"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.resizeTextMaxSize), x=> m_InternalObject.resizeTextMaxSize = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["updateBounds"] = new BSReflectionReference(() => m_InternalObject.updateBounds ? BSObject.One : BSObject.Zero, x=> m_InternalObject.updateBounds = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["generationExtents"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.generationExtents), x=> m_InternalObject.generationExtents = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["pivot"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.pivot), x=> m_InternalObject.pivot = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["generateOutOfBounds"] = new BSReflectionReference(() => m_InternalObject.generateOutOfBounds ? BSObject.One : BSObject.Zero, x=> m_InternalObject.generateOutOfBounds = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.TextGenerationSettings>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
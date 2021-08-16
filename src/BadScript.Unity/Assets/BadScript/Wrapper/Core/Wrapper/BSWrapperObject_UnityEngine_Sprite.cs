using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Sprite : BSWrapperObject<UnityEngine.Sprite>

    {
        public BSWrapperObject_UnityEngine_Sprite(UnityEngine.Sprite obj) : base(obj)
        {
            m_Properties["bounds"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Bounds(m_InternalObject.bounds), null);
            m_Properties["rect"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(m_InternalObject.rect), null);
            m_Properties["border"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector4(m_InternalObject.border), null);
            m_Properties["texture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(m_InternalObject.texture), null);
            m_Properties["pixelsPerUnit"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.pixelsPerUnit), null);
            m_Properties["spriteAtlasTextureScale"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.spriteAtlasTextureScale), null);
            m_Properties["associatedAlphaSplitTexture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture2D(m_InternalObject.associatedAlphaSplitTexture), null);
            m_Properties["pivot"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.pivot), null);
            m_Properties["packed"] = new BSReflectionReference(() => m_InternalObject.packed ? BSObject.One : BSObject.Zero, null);
            m_Properties["textureRect"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(m_InternalObject.textureRect), null);
            m_Properties["textureRectOffset"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.textureRectOffset), null);
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["GetPhysicsShapeCount"] = new BSFunctionReference(new BSFunction("function GetPhysicsShapeCount()", a => new BSObject((decimal)m_InternalObject.GetPhysicsShapeCount()), 0));
            m_Properties["GetPhysicsShapePointCount"] = new BSFunctionReference(new BSFunction("function GetPhysicsShapePointCount(shapeIdx)", a => new BSObject((decimal)m_InternalObject.GetPhysicsShapePointCount(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
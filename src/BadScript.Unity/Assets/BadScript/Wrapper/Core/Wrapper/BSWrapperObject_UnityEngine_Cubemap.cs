using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Cubemap : BSWrapperObject<UnityEngine.Cubemap>

    {
        public BSWrapperObject_UnityEngine_Cubemap(UnityEngine.Cubemap obj) : base(obj)
        {
            m_Properties["isReadable"] = new BSReflectionReference(() => m_InternalObject.isReadable ? BSObject.One : BSObject.Zero, null);
            m_Properties["streamingMipmaps"] = new BSReflectionReference(() => m_InternalObject.streamingMipmaps ? BSObject.One : BSObject.Zero, null);
            m_Properties["streamingMipmapsPriority"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.streamingMipmapsPriority), null);
            m_Properties["requestedMipmapLevel"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.requestedMipmapLevel), x=> m_InternalObject.requestedMipmapLevel = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["desiredMipmapLevel"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.desiredMipmapLevel), null);
            m_Properties["loadingMipmapLevel"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.loadingMipmapLevel), null);
            m_Properties["loadedMipmapLevel"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.loadedMipmapLevel), null);
            m_Properties["mipmapCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.mipmapCount), null);
            m_Properties["width"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.width), x=> m_InternalObject.width = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["height"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.height), x=> m_InternalObject.height = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["anisoLevel"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.anisoLevel), x=> m_InternalObject.anisoLevel = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["mipMapBias"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.mipMapBias), x=> m_InternalObject.mipMapBias = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["texelSize"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.texelSize), null);
            m_Properties["updateCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.updateCount), null);
            m_Properties["imageContentsHash"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Hash128(m_InternalObject.imageContentsHash), x=> m_InternalObject.imageContentsHash = WrapperHelper.UnwrapObject<UnityEngine.Hash128>(x));
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["UpdateExternalTexture"] = new BSFunctionReference(new BSFunction("function UpdateExternalTexture(nativeTexture)", a => {
                m_InternalObject.UpdateExternalTexture(WrapperHelper.UnwrapObject<System.IntPtr>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SmoothEdges"] = new BSFunctionReference(new BSFunction("function SmoothEdges(smoothRegionWidthInPixels)", a => {
                m_InternalObject.SmoothEdges(WrapperHelper.UnwrapObject<System.Int32>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SmoothEdges"] = new BSFunctionReference(new BSFunction("function SmoothEdges()", a => {
                m_InternalObject.SmoothEdges();
                return new BSObject(null);
            }, 0));
            m_Properties["ClearRequestedMipmapLevel"] = new BSFunctionReference(new BSFunction("function ClearRequestedMipmapLevel()", a => {
                m_InternalObject.ClearRequestedMipmapLevel();
                return new BSObject(null);
            }, 0));
            m_Properties["IsRequestedMipmapLevelLoaded"] = new BSFunctionReference(new BSFunction("function IsRequestedMipmapLevelLoaded()", a => m_InternalObject.IsRequestedMipmapLevelLoaded() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["Apply"] = new BSFunctionReference(new BSFunction("function Apply(updateMipmaps, makeNoLongerReadable)", a => {
                m_InternalObject.Apply(WrapperHelper.UnwrapObject<System.Boolean>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Apply"] = new BSFunctionReference(new BSFunction("function Apply(updateMipmaps)", a => {
                m_InternalObject.Apply(WrapperHelper.UnwrapObject<System.Boolean>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Apply"] = new BSFunctionReference(new BSFunction("function Apply()", a => {
                m_InternalObject.Apply();
                return new BSObject(null);
            }, 0));
            m_Properties["GetNativeTexturePtr"] = new BSFunctionReference(new BSFunction("function GetNativeTexturePtr()", a => new BSWrapperObject_System_IntPtr(m_InternalObject.GetNativeTexturePtr()), 0));
            m_Properties["GetNativeTextureID"] = new BSFunctionReference(new BSFunction("function GetNativeTextureID()", a => new BSObject((decimal)m_InternalObject.GetNativeTextureID()), 0));
            m_Properties["IncrementUpdateCount"] = new BSFunctionReference(new BSFunction("function IncrementUpdateCount()", a => {
                m_InternalObject.IncrementUpdateCount();
                return new BSObject(null);
            }, 0));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}
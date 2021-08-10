using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_RenderPipelineAsset : BSWrapperObject < RenderPipelineAsset >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_RenderPipelineAsset( RenderPipelineAsset obj ) : base( obj )
        {
            m_Properties["terrainBrushPassIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.terrainBrushPassIndex ),
                null );

            m_Properties["defaultMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.defaultMaterial ),
                null );

            m_Properties["autodeskInteractiveShader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.autodeskInteractiveShader ),
                null );

            m_Properties["autodeskInteractiveTransparentShader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.autodeskInteractiveTransparentShader ),
                null );

            m_Properties["autodeskInteractiveMaskedShader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.autodeskInteractiveMaskedShader ),
                null );

            m_Properties["terrainDetailLitShader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.terrainDetailLitShader ),
                null );

            m_Properties["terrainDetailGrassShader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.terrainDetailGrassShader ),
                null );

            m_Properties["terrainDetailGrassBillboardShader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.terrainDetailGrassBillboardShader ),
                null );

            m_Properties["defaultParticleMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.defaultParticleMaterial ),
                null );

            m_Properties["defaultLineMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.defaultLineMaterial ),
                null );

            m_Properties["defaultTerrainMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.defaultTerrainMaterial ),
                null );

            m_Properties["defaultUIMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.defaultUIMaterial ),
                null );

            m_Properties["defaultUIOverdrawMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.defaultUIOverdrawMaterial ),
                null );

            m_Properties["defaultUIETC1SupportedMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.defaultUIETC1SupportedMaterial ),
                null );

            m_Properties["default2DMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.default2DMaterial ),
                null );

            m_Properties["defaultShader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.defaultShader ),
                null );

            m_Properties["defaultSpeedTree7Shader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.defaultSpeedTree7Shader ),
                null );

            m_Properties["defaultSpeedTree8Shader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.defaultSpeedTree8Shader ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

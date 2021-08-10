using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_DrawingSettings : BSWrapperObject < DrawingSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_DrawingSettings( DrawingSettings obj ) : base( obj )
        {
            m_Properties["sortingSettings"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_SortingSettings( m_InternalObject.sortingSettings ),
                x => m_InternalObject.sortingSettings = WrapperHelper.UnwrapObject < SortingSettings >( x ) );

            m_Properties["enableDynamicBatching"] = new BSReflectionReference(
                () => m_InternalObject.enableDynamicBatching ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableDynamicBatching = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enableInstancing"] = new BSReflectionReference(
                () => m_InternalObject.enableInstancing ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableInstancing = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overrideMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.overrideMaterial ),
                x => m_InternalObject.overrideMaterial = WrapperHelper.UnwrapObject < Material >( x ) );

            m_Properties["overrideMaterialPassIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.overrideMaterialPassIndex ),
                x => m_InternalObject.overrideMaterialPassIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["mainLightIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mainLightIndex ),
                x => m_InternalObject.mainLightIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["GetShaderPassName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetShaderPassName(index)",
                    a => new BSWrapperObject_UnityEngine_Rendering_ShaderTagId(
                        m_InternalObject.GetShaderPassName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < DrawingSettings >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

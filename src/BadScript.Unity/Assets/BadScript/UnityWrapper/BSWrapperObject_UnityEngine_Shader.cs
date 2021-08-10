using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Shader : BSWrapperObject < Shader >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Shader( Shader obj ) : base( obj )
        {
            m_Properties["maximumLOD"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maximumLOD ),
                x => m_InternalObject.maximumLOD = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["isSupported"] = new BSReflectionReference(
                () => m_InternalObject.isSupported ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["renderQueue"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.renderQueue ),
                null );

            m_Properties["passCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.passCount ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetDependency"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDependency(name)",
                    a => new BSWrapperObject_UnityEngine_Shader(
                        m_InternalObject.GetDependency( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["FindPassTagValue"] = new BSFunctionReference(
                new BSFunction(
                    "function FindPassTagValue(passIndex, tagName)",
                    a => new BSWrapperObject_UnityEngine_Rendering_ShaderTagId(
                        m_InternalObject.FindPassTagValue(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ShaderTagId >( a[1] ) ) ),
                    2 ) );

            m_Properties["FindPropertyIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function FindPropertyIndex(propertyName)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.FindPropertyIndex(
                            WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPropertyName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyName(propertyIndex)",
                    a => new BSObject( m_InternalObject.GetPropertyName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPropertyNameId"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyNameId(propertyIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetPropertyNameId( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPropertyDescription"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyDescription(propertyIndex)",
                    a => new BSObject(
                        m_InternalObject.GetPropertyDescription( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPropertyDefaultFloatValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyDefaultFloatValue(propertyIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetPropertyDefaultFloatValue(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPropertyDefaultVectorValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyDefaultVectorValue(propertyIndex)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetPropertyDefaultVectorValue( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPropertyRangeLimits"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyRangeLimits(propertyIndex)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetPropertyRangeLimits( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPropertyTextureDefaultName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyTextureDefaultName(propertyIndex)",
                    a => new BSObject(
                        m_InternalObject.GetPropertyTextureDefaultName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

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
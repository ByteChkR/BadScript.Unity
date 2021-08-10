using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_MaterialPropertyBlock : BSWrapperObject < MaterialPropertyBlock >

    {
        #region Public

        public BSWrapperObject_UnityEngine_MaterialPropertyBlock( MaterialPropertyBlock obj ) : base( obj )
        {
            m_Properties["isEmpty"] = new BSReflectionReference(
                () => m_InternalObject.isEmpty ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector(name)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetVector( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetVector( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetColor(name)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetColor( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetColor(nameID)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetColor( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMatrix(name)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetMatrix( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMatrix(nameID)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetMatrix( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(name)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        m_InternalObject.GetTexture( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(nameID)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        m_InternalObject.GetTexture( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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

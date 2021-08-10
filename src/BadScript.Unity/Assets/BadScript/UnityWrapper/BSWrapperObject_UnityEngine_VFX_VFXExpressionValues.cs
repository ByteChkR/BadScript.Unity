using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.VFX;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_VFX_VFXExpressionValues : BSWrapperObject < VFXExpressionValues >

    {
        #region Public

        public BSWrapperObject_UnityEngine_VFX_VFXExpressionValues( VFXExpressionValues obj ) : base( obj )
        {
            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(nameID)",
                    a => m_InternalObject.GetBool( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUInt(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUInt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector2"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector2(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetVector2( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector3"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector3(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetVector3( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector4"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector4(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetVector4( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMatrix4x4"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMatrix4x4(nameID)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetMatrix4x4( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(nameID)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        m_InternalObject.GetTexture( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMesh(nameID)",
                    a => new BSWrapperObject_UnityEngine_Mesh(
                        m_InternalObject.GetMesh( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAnimationCurve"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAnimationCurve(nameID)",
                    a => new BSWrapperObject_UnityEngine_AnimationCurve(
                        m_InternalObject.GetAnimationCurve( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetGradient"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGradient(nameID)",
                    a => new BSWrapperObject_UnityEngine_Gradient(
                        m_InternalObject.GetGradient( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(name)",
                    a => m_InternalObject.GetBool( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUInt(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector2"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector2(name)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetVector2( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector3"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector3(name)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetVector3( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector4"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector4(name)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetVector4( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMatrix4x4"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMatrix4x4(name)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetMatrix4x4( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(name)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        m_InternalObject.GetTexture( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAnimationCurve"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAnimationCurve(name)",
                    a => new BSWrapperObject_UnityEngine_AnimationCurve(
                        m_InternalObject.GetAnimationCurve( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetGradient"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGradient(name)",
                    a => new BSWrapperObject_UnityEngine_Gradient(
                        m_InternalObject.GetGradient( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMesh(name)",
                    a => new BSWrapperObject_UnityEngine_Mesh(
                        m_InternalObject.GetMesh( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
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

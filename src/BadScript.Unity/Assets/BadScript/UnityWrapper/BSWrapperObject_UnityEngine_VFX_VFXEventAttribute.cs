using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.VFX;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_VFX_VFXEventAttribute : BSWrapperObject < VFXEventAttribute >

    {
        #region Public

        public BSWrapperObject_UnityEngine_VFX_VFXEventAttribute( VFXEventAttribute obj ) : base( obj )
        {
            m_Properties["HasBool"] = new BSFunctionReference(
                new BSFunction(
                    "function HasBool(nameID)",
                    a => m_InternalObject.HasBool( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasInt"] = new BSFunctionReference(
                new BSFunction(
                    "function HasInt(nameID)",
                    a => m_InternalObject.HasInt( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasUint"] = new BSFunctionReference(
                new BSFunction(
                    "function HasUint(nameID)",
                    a => m_InternalObject.HasUint( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function HasFloat(nameID)",
                    a => m_InternalObject.HasFloat( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector2"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector2(nameID)",
                    a => m_InternalObject.HasVector2( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector3"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector3(nameID)",
                    a => m_InternalObject.HasVector3( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector4"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector4(nameID)",
                    a => m_InternalObject.HasVector4( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasMatrix4x4"] = new BSFunctionReference(
                new BSFunction(
                    "function HasMatrix4x4(nameID)",
                    a => m_InternalObject.HasMatrix4x4( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

            m_Properties["GetUint"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUint(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUint( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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

            m_Properties["HasBool"] = new BSFunctionReference(
                new BSFunction(
                    "function HasBool(name)",
                    a => m_InternalObject.HasBool( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasInt"] = new BSFunctionReference(
                new BSFunction(
                    "function HasInt(name)",
                    a => m_InternalObject.HasInt( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasUint"] = new BSFunctionReference(
                new BSFunction(
                    "function HasUint(name)",
                    a => m_InternalObject.HasUint( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function HasFloat(name)",
                    a => m_InternalObject.HasFloat( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector2"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector2(name)",
                    a => m_InternalObject.HasVector2( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector3"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector3(name)",
                    a => m_InternalObject.HasVector3( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasVector4"] = new BSFunctionReference(
                new BSFunction(
                    "function HasVector4(name)",
                    a => m_InternalObject.HasVector4( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasMatrix4x4"] = new BSFunctionReference(
                new BSFunction(
                    "function HasMatrix4x4(name)",
                    a => m_InternalObject.HasMatrix4x4( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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

            m_Properties["GetUint"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUint(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUint( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
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

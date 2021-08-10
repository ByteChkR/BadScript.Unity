using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Sprite : BSWrapperObject < Sprite >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Sprite( Sprite obj ) : base( obj )
        {
            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                null );

            m_Properties["rect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.rect ),
                null );

            m_Properties["border"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.border ),
                null );

            m_Properties["texture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.texture ),
                null );

            m_Properties["pixelsPerUnit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pixelsPerUnit ),
                null );

            m_Properties["spriteAtlasTextureScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spriteAtlasTextureScale ),
                null );

            m_Properties["associatedAlphaSplitTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.associatedAlphaSplitTexture ),
                null );

            m_Properties["pivot"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.pivot ),
                null );

            m_Properties["packed"] = new BSReflectionReference(
                () => m_InternalObject.packed ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["textureRect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.textureRect ),
                null );

            m_Properties["textureRectOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.textureRectOffset ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetPhysicsShapePointCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPhysicsShapePointCount(shapeIdx)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetPhysicsShapePointCount(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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
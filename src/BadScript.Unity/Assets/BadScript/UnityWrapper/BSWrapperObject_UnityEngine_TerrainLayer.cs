using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TerrainLayer : BSWrapperObject < TerrainLayer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TerrainLayer( TerrainLayer obj ) : base( obj )
        {
            m_Properties["diffuseTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.diffuseTexture ),
                x => m_InternalObject.diffuseTexture = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["normalMapTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.normalMapTexture ),
                x => m_InternalObject.normalMapTexture = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["maskMapTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.maskMapTexture ),
                x => m_InternalObject.maskMapTexture = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["tileSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.tileSize ),
                x => m_InternalObject.tileSize = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["tileOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.tileOffset ),
                x => m_InternalObject.tileOffset = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["specular"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.specular ),
                x => m_InternalObject.specular = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["metallic"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.metallic ),
                x => m_InternalObject.metallic = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["smoothness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.smoothness ),
                x => m_InternalObject.smoothness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["normalScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.normalScale ),
                x => m_InternalObject.normalScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["diffuseRemapMin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.diffuseRemapMin ),
                x => m_InternalObject.diffuseRemapMin = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["diffuseRemapMax"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.diffuseRemapMax ),
                x => m_InternalObject.diffuseRemapMax = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["maskMapRemapMin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.maskMapRemapMin ),
                x => m_InternalObject.maskMapRemapMin = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["maskMapRemapMax"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.maskMapRemapMax ),
                x => m_InternalObject.maskMapRemapMax = WrapperHelper.UnwrapObject < Vector4 >( x ) );

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

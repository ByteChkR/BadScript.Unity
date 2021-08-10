using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SplatPrototype : BSWrapperObject < SplatPrototype >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SplatPrototype( SplatPrototype obj ) : base( obj )
        {
            m_Properties["texture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.texture ),
                x => m_InternalObject.texture = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["normalMap"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.normalMap ),
                x => m_InternalObject.normalMap = WrapperHelper.UnwrapObject < Texture2D >( x ) );

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

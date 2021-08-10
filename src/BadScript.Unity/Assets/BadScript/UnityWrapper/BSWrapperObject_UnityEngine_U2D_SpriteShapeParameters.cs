using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.U2D;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_U2D_SpriteShapeParameters : BSWrapperObject < SpriteShapeParameters >

    {
        #region Public

        public BSWrapperObject_UnityEngine_U2D_SpriteShapeParameters( SpriteShapeParameters obj ) : base( obj )
        {
            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.transform ),
                x => m_InternalObject.transform = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["fillTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.fillTexture ),
                x => m_InternalObject.fillTexture = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["fillScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fillScale ),
                x => m_InternalObject.fillScale = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["splineDetail"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.splineDetail ),
                x => m_InternalObject.splineDetail = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["angleThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angleThreshold ),
                x => m_InternalObject.angleThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderPivot"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderPivot ),
                x => m_InternalObject.borderPivot = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bevelCutoff"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bevelCutoff ),
                x => m_InternalObject.bevelCutoff = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bevelSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bevelSize ),
                x => m_InternalObject.bevelSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["carpet"] = new BSReflectionReference(
                () => m_InternalObject.carpet ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.carpet = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["smartSprite"] = new BSReflectionReference(
                () => m_InternalObject.smartSprite ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.smartSprite = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["adaptiveUV"] = new BSReflectionReference(
                () => m_InternalObject.adaptiveUV ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.adaptiveUV = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["spriteBorders"] = new BSReflectionReference(
                () => m_InternalObject.spriteBorders ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.spriteBorders = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["stretchUV"] = new BSReflectionReference(
                () => m_InternalObject.stretchUV ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.stretchUV = WrapperHelper.UnwrapObject < bool >( x ) );

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

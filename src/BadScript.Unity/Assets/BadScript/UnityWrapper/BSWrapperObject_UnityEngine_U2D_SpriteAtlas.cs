using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.U2D;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_U2D_SpriteAtlas : BSWrapperObject < SpriteAtlas >

    {
        #region Public

        public BSWrapperObject_UnityEngine_U2D_SpriteAtlas( SpriteAtlas obj ) : base( obj )
        {
            m_Properties["isVariant"] = new BSReflectionReference(
                () => m_InternalObject.isVariant ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["tag"] = new BSReflectionReference( () => new BSObject( m_InternalObject.tag ), null );

            m_Properties["spriteCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spriteCount ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["CanBindTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CanBindTo(sprite)",
                    a => m_InternalObject.CanBindTo( WrapperHelper.UnwrapObject < Sprite >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetSprite"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSprite(name)",
                    a => new BSWrapperObject_UnityEngine_Sprite(
                        m_InternalObject.GetSprite( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
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

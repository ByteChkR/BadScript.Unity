using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UI_SpriteState : BSWrapperObject < SpriteState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_SpriteState( SpriteState obj ) : base( obj )
        {
            m_Properties["highlightedSprite"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Sprite( m_InternalObject.highlightedSprite ),
                x => m_InternalObject.highlightedSprite = WrapperHelper.UnwrapObject < Sprite >( x ) );

            m_Properties["pressedSprite"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Sprite( m_InternalObject.pressedSprite ),
                x => m_InternalObject.pressedSprite = WrapperHelper.UnwrapObject < Sprite >( x ) );

            m_Properties["selectedSprite"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Sprite( m_InternalObject.selectedSprite ),
                x => m_InternalObject.selectedSprite = WrapperHelper.UnwrapObject < Sprite >( x ) );

            m_Properties["disabledSprite"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Sprite( m_InternalObject.disabledSprite ),
                x => m_InternalObject.disabledSprite = WrapperHelper.UnwrapObject < Sprite >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < SpriteState >( a[0] ) )
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

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}

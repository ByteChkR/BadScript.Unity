using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UI_AnimationTriggers : BSWrapperObject < AnimationTriggers >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_AnimationTriggers( AnimationTriggers obj ) : base( obj )
        {
            m_Properties["normalTrigger"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.normalTrigger ),
                x => m_InternalObject.normalTrigger = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["highlightedTrigger"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.highlightedTrigger ),
                x => m_InternalObject.highlightedTrigger = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["pressedTrigger"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.pressedTrigger ),
                x => m_InternalObject.pressedTrigger = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["selectedTrigger"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.selectedTrigger ),
                x => m_InternalObject.selectedTrigger = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["disabledTrigger"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.disabledTrigger ),
                x => m_InternalObject.disabledTrigger = WrapperHelper.UnwrapObject < string >( x ) );

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

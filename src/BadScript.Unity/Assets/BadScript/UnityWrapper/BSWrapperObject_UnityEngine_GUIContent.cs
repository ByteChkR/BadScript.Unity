using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GUIContent : BSWrapperObject < GUIContent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GUIContent( GUIContent obj ) : base( obj )
        {
            m_Properties["text"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.text ),
                x => m_InternalObject.text = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["image"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.image ),
                x => m_InternalObject.image = WrapperHelper.UnwrapObject < Texture >( x ) );

            m_Properties["tooltip"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tooltip ),
                x => m_InternalObject.tooltip = WrapperHelper.UnwrapObject < string >( x ) );

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

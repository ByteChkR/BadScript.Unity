using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UICharInfo : BSWrapperObject < UICharInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UICharInfo( UICharInfo obj ) : base( obj )
        {
            m_Properties["cursorPos"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.cursorPos ),
                x => m_InternalObject.cursorPos = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["charWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.charWidth ),
                x => m_InternalObject.charWidth = WrapperHelper.UnwrapObject < float >( x ) );

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

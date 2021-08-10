using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GUIStyleState : BSWrapperObject < GUIStyleState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GUIStyleState( GUIStyleState obj ) : base( obj )
        {
            m_Properties["background"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.background ),
                x => m_InternalObject.background = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["textColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.textColor ),
                x => m_InternalObject.textColor = WrapperHelper.UnwrapObject < Color >( x ) );

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

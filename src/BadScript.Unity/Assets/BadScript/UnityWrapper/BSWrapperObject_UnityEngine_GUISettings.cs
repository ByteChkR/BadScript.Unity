using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GUISettings : BSWrapperObject < GUISettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GUISettings( GUISettings obj ) : base( obj )
        {
            m_Properties["doubleClickSelectsWord"] = new BSReflectionReference(
                () => m_InternalObject.doubleClickSelectsWord ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.doubleClickSelectsWord = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["tripleClickSelectsLine"] = new BSReflectionReference(
                () => m_InternalObject.tripleClickSelectsLine ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.tripleClickSelectsLine = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["cursorColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.cursorColor ),
                x => m_InternalObject.cursorColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["cursorFlashSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cursorFlashSpeed ),
                x => m_InternalObject.cursorFlashSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["selectionColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.selectionColor ),
                x => m_InternalObject.selectionColor = WrapperHelper.UnwrapObject < Color >( x ) );

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

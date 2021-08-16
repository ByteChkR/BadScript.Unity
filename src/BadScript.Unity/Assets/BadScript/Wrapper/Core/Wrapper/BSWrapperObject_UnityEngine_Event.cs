using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Event : BSWrapperObject < Event >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Event( Event obj ) : base( obj )
        {
            m_Properties["mousePosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.mousePosition ),
                x => m_InternalObject.mousePosition = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["delta"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.delta ),
                x => m_InternalObject.delta = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["button"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.button ),
                x => m_InternalObject.button = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["pressure"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pressure ),
                x => m_InternalObject.pressure = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["clickCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clickCount ),
                x => m_InternalObject.clickCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["character"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Char( m_InternalObject.character ),
                x => m_InternalObject.character = WrapperHelper.UnwrapObject < char >( x ) );

            m_Properties["displayIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.displayIndex ),
                x => m_InternalObject.displayIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["commandName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.commandName ),
                x => m_InternalObject.commandName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["shift"] = new BSReflectionReference(
                () => m_InternalObject.shift ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.shift = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["control"] = new BSReflectionReference(
                () => m_InternalObject.control ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.control = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["alt"] = new BSReflectionReference(
                () => m_InternalObject.alt ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.alt = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["command"] = new BSReflectionReference(
                () => m_InternalObject.command ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.command = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["capsLock"] = new BSReflectionReference(
                () => m_InternalObject.capsLock ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.capsLock = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["numeric"] = new BSReflectionReference(
                () => m_InternalObject.numeric ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.numeric = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["functionKey"] = new BSReflectionReference(
                () => m_InternalObject.functionKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isKey"] = new BSReflectionReference(
                () => m_InternalObject.isKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isMouse"] = new BSReflectionReference(
                () => m_InternalObject.isMouse ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isScrollWheel"] = new BSReflectionReference(
                () => m_InternalObject.isScrollWheel ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

            m_Properties["Use"] = new BSFunctionReference(
                new BSFunction(
                    "function Use()",
                    a =>
                    {
                        m_InternalObject.Use();

                        return new BSObject( null );
                    },
                    0 ) );

        }

        #endregion
    }

}

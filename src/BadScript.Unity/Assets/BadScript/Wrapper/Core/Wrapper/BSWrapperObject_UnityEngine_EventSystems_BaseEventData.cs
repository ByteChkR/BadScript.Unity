using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_EventSystems_BaseEventData : BSWrapperObject < BaseEventData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_EventSystems_BaseEventData( BaseEventData obj ) : base( obj )
        {
            m_Properties["currentInputModule"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_EventSystems_BaseInputModule(
                    m_InternalObject.currentInputModule ),
                null );

            m_Properties["selectedObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.selectedObject ),
                x => m_InternalObject.selectedObject = WrapperHelper.UnwrapObject < GameObject >( x ) );

            m_Properties["used"] = new BSReflectionReference(
                () => m_InternalObject.used ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Reset"] = new BSFunctionReference(
                new BSFunction(
                    "function Reset()",
                    a =>
                    {
                        m_InternalObject.Reset();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Use"] = new BSFunctionReference(
                new BSFunction(
                    "function Use()",
                    a =>
                    {
                        m_InternalObject.Use();

                        return new BSObject( null );
                    },
                    0 ) );

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

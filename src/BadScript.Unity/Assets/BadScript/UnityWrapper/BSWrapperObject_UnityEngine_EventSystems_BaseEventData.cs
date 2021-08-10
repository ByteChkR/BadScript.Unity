using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BSWrapperObjects.Internal.UnityWrapper
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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class
        BSWrapperObject_UnityEngine_UIElements_ContextualMenuManager : BSWrapperObject < ContextualMenuManager >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_ContextualMenuManager( ContextualMenuManager obj ) : base( obj )
        {
            m_Properties["DisplayMenuIfEventMatches"] = new BSFunctionReference(
                new BSFunction(
                    "function DisplayMenuIfEventMatches(evt, eventHandler)",
                    a =>
                    {
                        m_InternalObject.DisplayMenuIfEventMatches(
                            WrapperHelper.UnwrapObject < EventBase >( a[0] ),
                            WrapperHelper.UnwrapObject < IEventHandler >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["DisplayMenu"] = new BSFunctionReference(
                new BSFunction(
                    "function DisplayMenu(triggerEvent, target)",
                    a =>
                    {
                        m_InternalObject.DisplayMenu(
                            WrapperHelper.UnwrapObject < EventBase >( a[0] ),
                            WrapperHelper.UnwrapObject < IEventHandler >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

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

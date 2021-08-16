using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class
        BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem : BSWrapperObject <
            IVisualElementScheduledItem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem( IVisualElementScheduledItem obj ) :
            base( obj )
        {
            m_Properties["element"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VisualElement( m_InternalObject.element ),
                null );

            m_Properties["isActive"] = new BSReflectionReference(
                () => m_InternalObject.isActive ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Resume"] = new BSFunctionReference(
                new BSFunction(
                    "function Resume()",
                    a =>
                    {
                        m_InternalObject.Resume();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Pause"] = new BSFunctionReference(
                new BSFunction(
                    "function Pause()",
                    a =>
                    {
                        m_InternalObject.Pause();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ExecuteLater"] = new BSFunctionReference(
                new BSFunction(
                    "function ExecuteLater(delayMs)",
                    a =>
                    {
                        m_InternalObject.ExecuteLater( WrapperHelper.UnwrapObject < long >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["StartingIn"] = new BSFunctionReference(
                new BSFunction(
                    "function StartingIn(delayMs)",
                    a => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem(
                        m_InternalObject.StartingIn( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

            m_Properties["Every"] = new BSFunctionReference(
                new BSFunction(
                    "function Every(intervalMs)",
                    a => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem(
                        m_InternalObject.Every( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

            m_Properties["ForDuration"] = new BSFunctionReference(
                new BSFunction(
                    "function ForDuration(durationMs)",
                    a => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem(
                        m_InternalObject.ForDuration( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

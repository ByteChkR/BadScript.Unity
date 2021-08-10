using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
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

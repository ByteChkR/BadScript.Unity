using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduler : BSWrapperObject < IVisualElementScheduler >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduler( IVisualElementScheduler obj ) : base(
            obj )
        {
            m_Properties["Execute"] = new BSFunctionReference(
                new BSFunction(
                    "function Execute(updateEvent)",
                    a => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem(
                        m_InternalObject.Execute( WrapperHelper.UnwrapObject < Action >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

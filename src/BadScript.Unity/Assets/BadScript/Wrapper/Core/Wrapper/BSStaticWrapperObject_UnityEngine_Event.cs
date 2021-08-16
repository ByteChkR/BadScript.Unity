using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Event : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Event() : base( typeof( Event ) )
        {
            m_StaticProperties["current"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Event( Event.current ),
                x => Event.current = WrapperHelper.UnwrapObject < Event >( x ) );

            m_StaticProperties["PopEvent"] = new BSFunctionReference(
                new BSFunction(
                    "function PopEvent(outEvent)",
                    a => Event.PopEvent( WrapperHelper.UnwrapObject < Event >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetEventCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEventCount()",
                    a => new BSObject( ( decimal ) Event.GetEventCount() ),
                    0 ) );

            m_StaticProperties["KeyboardEvent"] = new BSFunctionReference(
                new BSFunction(
                    "function KeyboardEvent(key)",
                    a => new BSWrapperObject_UnityEngine_Event(
                        Event.KeyboardEvent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AndroidInput : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AndroidInput() : base( typeof( AndroidInput ) )
        {
            m_StaticProperties["touchCountSecondary"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AndroidInput.touchCountSecondary ),
                null );

            m_StaticProperties["secondaryTouchEnabled"] = new BSReflectionReference(
                () => AndroidInput.secondaryTouchEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["secondaryTouchWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AndroidInput.secondaryTouchWidth ),
                null );

            m_StaticProperties["secondaryTouchHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AndroidInput.secondaryTouchHeight ),
                null );

            m_StaticProperties["GetSecondaryTouch"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSecondaryTouch(index)",
                    a => new BSWrapperObject_UnityEngine_Touch(
                        AndroidInput.GetSecondaryTouch( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

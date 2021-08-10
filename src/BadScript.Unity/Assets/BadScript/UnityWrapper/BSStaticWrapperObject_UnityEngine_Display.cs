using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Display : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Display() : base( typeof( Display ) )
        {
            m_StaticProperties["main"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Display( Display.main ),
                null );

            m_StaticProperties["RelativeMouseAt"] = new BSFunctionReference(
                new BSFunction(
                    "function RelativeMouseAt(inputMouseCoordinates)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        Display.RelativeMouseAt( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

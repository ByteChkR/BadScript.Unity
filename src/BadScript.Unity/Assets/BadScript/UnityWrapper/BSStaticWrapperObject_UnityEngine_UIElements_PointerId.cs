using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_PointerId : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_PointerId() : base( typeof( PointerId ) )
        {
            m_StaticProperties["maxPointers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerId.maxPointers ),
                null );

            m_StaticProperties["invalidPointerId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerId.invalidPointerId ),
                null );

            m_StaticProperties["mousePointerId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerId.mousePointerId ),
                null );

            m_StaticProperties["touchPointerIdBase"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerId.touchPointerIdBase ),
                null );

            m_StaticProperties["touchPointerCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerId.touchPointerCount ),
                null );

            m_StaticProperties["penPointerIdBase"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerId.penPointerIdBase ),
                null );

            m_StaticProperties["penPointerCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PointerId.penPointerCount ),
                null );

        }

        #endregion
    }

}

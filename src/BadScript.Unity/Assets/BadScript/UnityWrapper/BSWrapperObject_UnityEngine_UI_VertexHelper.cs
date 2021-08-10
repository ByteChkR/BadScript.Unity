using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_VertexHelper : BSWrapperObject < VertexHelper >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_VertexHelper( VertexHelper obj ) : base( obj )
        {
            m_Properties["currentVertCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.currentVertCount ),
                null );

            m_Properties["currentIndexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.currentIndexCount ),
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

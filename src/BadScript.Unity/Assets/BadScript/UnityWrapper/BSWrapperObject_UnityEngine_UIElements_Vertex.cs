using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_Vertex : BSWrapperObject < Vertex >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_Vertex( Vertex obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["tint"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color32( m_InternalObject.tint ),
                x => m_InternalObject.tint = WrapperHelper.UnwrapObject < Color32 >( x ) );

            m_Properties["uv"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.uv ),
                x => m_InternalObject.uv = WrapperHelper.UnwrapObject < Vector2 >( x ) );

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

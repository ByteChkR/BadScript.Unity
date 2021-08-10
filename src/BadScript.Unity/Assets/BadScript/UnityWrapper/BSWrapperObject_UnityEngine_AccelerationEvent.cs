using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AccelerationEvent : BSWrapperObject < AccelerationEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AccelerationEvent( AccelerationEvent obj ) : base( obj )
        {
            m_Properties["acceleration"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.acceleration ),
                null );

            m_Properties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.deltaTime ),
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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_HumanLimit : BSWrapperObject < HumanLimit >

    {
        #region Public

        public BSWrapperObject_UnityEngine_HumanLimit( HumanLimit obj ) : base( obj )
        {
            m_Properties["useDefaultValues"] = new BSReflectionReference(
                () => m_InternalObject.useDefaultValues ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useDefaultValues = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["min"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.min ),
                x => m_InternalObject.min = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["max"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.max ),
                x => m_InternalObject.max = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["axisLength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.axisLength ),
                x => m_InternalObject.axisLength = WrapperHelper.UnwrapObject < float >( x ) );

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

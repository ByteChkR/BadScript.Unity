using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_JointSpring : BSWrapperObject < JointSpring >

    {
        #region Public

        public BSWrapperObject_UnityEngine_JointSpring( JointSpring obj ) : base( obj )
        {
            m_Properties["spring"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spring ),
                x => m_InternalObject.spring = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["damper"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.damper ),
                x => m_InternalObject.damper = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["targetPosition"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.targetPosition ),
                x => m_InternalObject.targetPosition = WrapperHelper.UnwrapObject < float >( x ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_JointMotor2D : BSWrapperObject < JointMotor2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_JointMotor2D( JointMotor2D obj ) : base( obj )
        {
            m_Properties["motorSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.motorSpeed ),
                x => m_InternalObject.motorSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxMotorTorque"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxMotorTorque ),
                x => m_InternalObject.maxMotorTorque = WrapperHelper.UnwrapObject < float >( x ) );

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

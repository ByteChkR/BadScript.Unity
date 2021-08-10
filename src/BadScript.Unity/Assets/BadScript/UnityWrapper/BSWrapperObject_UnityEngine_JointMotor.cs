using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_JointMotor : BSWrapperObject < JointMotor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_JointMotor( JointMotor obj ) : base( obj )
        {
            m_Properties["targetVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.targetVelocity ),
                x => m_InternalObject.targetVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["force"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.force ),
                x => m_InternalObject.force = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["freeSpin"] = new BSReflectionReference(
                () => m_InternalObject.freeSpin ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.freeSpin = WrapperHelper.UnwrapObject < bool >( x ) );

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

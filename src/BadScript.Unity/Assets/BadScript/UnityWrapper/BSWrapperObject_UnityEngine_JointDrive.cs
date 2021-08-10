using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_JointDrive : BSWrapperObject < JointDrive >

    {
        #region Public

        public BSWrapperObject_UnityEngine_JointDrive( JointDrive obj ) : base( obj )
        {
            m_Properties["positionSpring"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.positionSpring ),
                x => m_InternalObject.positionSpring = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["positionDamper"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.positionDamper ),
                x => m_InternalObject.positionDamper = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maximumForce"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maximumForce ),
                x => m_InternalObject.maximumForce = WrapperHelper.UnwrapObject < float >( x ) );

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

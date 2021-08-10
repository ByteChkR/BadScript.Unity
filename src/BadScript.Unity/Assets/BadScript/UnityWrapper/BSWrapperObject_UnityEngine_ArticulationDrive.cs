using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ArticulationDrive : BSWrapperObject < ArticulationDrive >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ArticulationDrive( ArticulationDrive obj ) : base( obj )
        {
            m_Properties["lowerLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lowerLimit ),
                x => m_InternalObject.lowerLimit = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["upperLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.upperLimit ),
                x => m_InternalObject.upperLimit = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["stiffness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stiffness ),
                x => m_InternalObject.stiffness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["damping"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.damping ),
                x => m_InternalObject.damping = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["forceLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.forceLimit ),
                x => m_InternalObject.forceLimit = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["target"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.target ),
                x => m_InternalObject.target = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["targetVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.targetVelocity ),
                x => m_InternalObject.targetVelocity = WrapperHelper.UnwrapObject < float >( x ) );

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

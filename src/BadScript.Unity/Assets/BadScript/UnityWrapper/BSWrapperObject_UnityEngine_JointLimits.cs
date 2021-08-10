using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_JointLimits : BSWrapperObject < JointLimits >

    {
        #region Public

        public BSWrapperObject_UnityEngine_JointLimits( JointLimits obj ) : base( obj )
        {
            m_Properties["min"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.min ),
                x => m_InternalObject.min = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["max"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.max ),
                x => m_InternalObject.max = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bounciness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounciness ),
                x => m_InternalObject.bounciness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bounceMinVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounceMinVelocity ),
                x => m_InternalObject.bounceMinVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["contactDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.contactDistance ),
                x => m_InternalObject.contactDistance = WrapperHelper.UnwrapObject < float >( x ) );

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

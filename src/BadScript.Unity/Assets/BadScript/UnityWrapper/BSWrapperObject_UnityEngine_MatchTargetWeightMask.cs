using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_MatchTargetWeightMask : BSWrapperObject < MatchTargetWeightMask >

    {
        #region Public

        public BSWrapperObject_UnityEngine_MatchTargetWeightMask( MatchTargetWeightMask obj ) : base( obj )
        {
            m_Properties["positionXYZWeight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.positionXYZWeight ),
                x => m_InternalObject.positionXYZWeight = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotationWeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rotationWeight ),
                x => m_InternalObject.rotationWeight = WrapperHelper.UnwrapObject < float >( x ) );

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
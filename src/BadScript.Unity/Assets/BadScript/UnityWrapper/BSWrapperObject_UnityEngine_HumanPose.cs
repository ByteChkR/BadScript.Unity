using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_HumanPose : BSWrapperObject < HumanPose >

    {
        #region Public

        public BSWrapperObject_UnityEngine_HumanPose( HumanPose obj ) : base( obj )
        {
            m_Properties["bodyPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.bodyPosition ),
                x => m_InternalObject.bodyPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["bodyRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.bodyRotation ),
                x => m_InternalObject.bodyRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

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

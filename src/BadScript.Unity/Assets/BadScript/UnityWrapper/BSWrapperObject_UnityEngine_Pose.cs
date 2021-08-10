using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Pose : BSWrapperObject < Pose >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Pose( Pose obj ) : base( obj )
        {
            m_Properties["forward"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.forward ),
                null );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.right ),
                null );

            m_Properties["up"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.up ),
                null );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format)",
                    a => new BSObject( m_InternalObject.ToString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTransformedBy"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTransformedBy(lhs)",
                    a => new BSWrapperObject_UnityEngine_Pose(
                        m_InternalObject.GetTransformedBy( WrapperHelper.UnwrapObject < Pose >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTransformedBy"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTransformedBy(lhs)",
                    a => new BSWrapperObject_UnityEngine_Pose(
                        m_InternalObject.GetTransformedBy( WrapperHelper.UnwrapObject < Transform >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Pose >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animations_TransformSceneHandle : BSWrapperObject < TransformSceneHandle >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_TransformSceneHandle( TransformSceneHandle obj ) : base( obj )
        {
            m_Properties["IsValid"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValid(stream)",
                    a => m_InternalObject.IsValid( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetPosition"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPosition(stream)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetPosition( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetLocalPosition"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLocalPosition(stream)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetLocalPosition( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetRotation"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRotation(stream)",
                    a => new BSWrapperObject_UnityEngine_Quaternion(
                        m_InternalObject.GetRotation( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetLocalRotation"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLocalRotation(stream)",
                    a => new BSWrapperObject_UnityEngine_Quaternion(
                        m_InternalObject.GetLocalRotation( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetLocalScale"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLocalScale(stream)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetLocalScale( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) ) ),
                    1 ) );

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

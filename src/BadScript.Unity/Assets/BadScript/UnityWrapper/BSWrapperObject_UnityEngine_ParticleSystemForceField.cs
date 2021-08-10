using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ParticleSystemForceField : BSWrapperObject < ParticleSystemForceField >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ParticleSystemForceField( ParticleSystemForceField obj ) : base( obj )
        {
            m_Properties["startRange"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startRange ),
                x => m_InternalObject.startRange = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["endRange"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.endRange ),
                x => m_InternalObject.endRange = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
                x => m_InternalObject.length = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["gravityFocus"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gravityFocus ),
                x => m_InternalObject.gravityFocus = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["rotationRandomness"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.rotationRandomness ),
                x => m_InternalObject.rotationRandomness = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["multiplyDragByParticleSize"] = new BSReflectionReference(
                () => m_InternalObject.multiplyDragByParticleSize ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.multiplyDragByParticleSize = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["multiplyDragByParticleVelocity"] = new BSReflectionReference(
                () => m_InternalObject.multiplyDragByParticleVelocity ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.multiplyDragByParticleVelocity = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["vectorField"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture3D( m_InternalObject.vectorField ),
                x => m_InternalObject.vectorField = WrapperHelper.UnwrapObject < Texture3D >( x ) );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

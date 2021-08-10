using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AudioEchoFilter : BSWrapperObject < AudioEchoFilter >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AudioEchoFilter( AudioEchoFilter obj ) : base( obj )
        {
            m_Properties["delay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.delay ),
                x => m_InternalObject.delay = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["decayRatio"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.decayRatio ),
                x => m_InternalObject.decayRatio = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["dryMix"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dryMix ),
                x => m_InternalObject.dryMix = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["wetMix"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.wetMix ),
                x => m_InternalObject.wetMix = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

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
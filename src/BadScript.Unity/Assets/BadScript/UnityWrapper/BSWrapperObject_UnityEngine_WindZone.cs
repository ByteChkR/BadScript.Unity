using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WindZone : BSWrapperObject < WindZone >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WindZone( WindZone obj ) : base( obj )
        {
            m_Properties["radius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.radius ),
                x => m_InternalObject.radius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["windMain"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.windMain ),
                x => m_InternalObject.windMain = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["windTurbulence"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.windTurbulence ),
                x => m_InternalObject.windTurbulence = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["windPulseMagnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.windPulseMagnitude ),
                x => m_InternalObject.windPulseMagnitude = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["windPulseFrequency"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.windPulseFrequency ),
                x => m_InternalObject.windPulseFrequency = WrapperHelper.UnwrapObject < float >( x ) );

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

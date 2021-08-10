using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Projector : BSWrapperObject < Projector >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Projector( Projector obj ) : base( obj )
        {
            m_Properties["nearClipPlane"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.nearClipPlane ),
                x => m_InternalObject.nearClipPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["farClipPlane"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.farClipPlane ),
                x => m_InternalObject.farClipPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["fieldOfView"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fieldOfView ),
                x => m_InternalObject.fieldOfView = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["aspectRatio"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.aspectRatio ),
                x => m_InternalObject.aspectRatio = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["orthographic"] = new BSReflectionReference(
                () => m_InternalObject.orthographic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.orthographic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["orthographicSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.orthographicSize ),
                x => m_InternalObject.orthographicSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["ignoreLayers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ignoreLayers ),
                x => m_InternalObject.ignoreLayers = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["material"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.material ),
                x => m_InternalObject.material = WrapperHelper.UnwrapObject < Material >( x ) );

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

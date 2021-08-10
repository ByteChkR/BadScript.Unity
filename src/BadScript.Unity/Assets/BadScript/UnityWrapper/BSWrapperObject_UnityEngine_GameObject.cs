using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GameObject : BSWrapperObject < GameObject >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GameObject( GameObject obj ) : base( obj )
        {
            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["layer"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layer ),
                x => m_InternalObject.layer = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["active"] = new BSReflectionReference(
                () => m_InternalObject.active ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.active = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["activeSelf"] = new BSReflectionReference(
                () => m_InternalObject.activeSelf ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["activeInHierarchy"] = new BSReflectionReference(
                () => m_InternalObject.activeInHierarchy ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isStatic"] = new BSReflectionReference(
                () => m_InternalObject.isStatic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isStatic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["scene"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SceneManagement_Scene( m_InternalObject.scene ),
                null );

            m_Properties["sceneCullingMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sceneCullingMask ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_OffMeshLink : BSWrapperObject < OffMeshLink >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_OffMeshLink( OffMeshLink obj ) : base( obj )
        {
            m_Properties["activated"] = new BSReflectionReference(
                () => m_InternalObject.activated ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.activated = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["occupied"] = new BSReflectionReference(
                () => m_InternalObject.occupied ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["costOverride"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.costOverride ),
                x => m_InternalObject.costOverride = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["biDirectional"] = new BSReflectionReference(
                () => m_InternalObject.biDirectional ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.biDirectional = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["navMeshLayer"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.navMeshLayer ),
                x => m_InternalObject.navMeshLayer = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["area"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.area ),
                x => m_InternalObject.area = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["autoUpdatePositions"] = new BSReflectionReference(
                () => m_InternalObject.autoUpdatePositions ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoUpdatePositions = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["startTransform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.startTransform ),
                x => m_InternalObject.startTransform = WrapperHelper.UnwrapObject < Transform >( x ) );

            m_Properties["endTransform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.endTransform ),
                x => m_InternalObject.endTransform = WrapperHelper.UnwrapObject < Transform >( x ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_EventSystems_RaycastResult : BSWrapperObject < RaycastResult >

    {
        #region Public

        public BSWrapperObject_UnityEngine_EventSystems_RaycastResult( RaycastResult obj ) : base( obj )
        {
            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                x => m_InternalObject.gameObject = WrapperHelper.UnwrapObject < GameObject >( x ) );

            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["module"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_EventSystems_BaseRaycaster( m_InternalObject.module ),
                x => m_InternalObject.module = WrapperHelper.UnwrapObject < BaseRaycaster >( x ) );

            m_Properties["distance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distance ),
                x => m_InternalObject.distance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["index"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.index ),
                x => m_InternalObject.index = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["depth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.depth ),
                x => m_InternalObject.depth = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sortingLayer"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sortingLayer ),
                x => m_InternalObject.sortingLayer = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sortingOrder"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sortingOrder ),
                x => m_InternalObject.sortingOrder = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["worldPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.worldPosition ),
                x => m_InternalObject.worldPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["worldNormal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.worldNormal ),
                x => m_InternalObject.worldNormal = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["screenPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.screenPosition ),
                x => m_InternalObject.screenPosition = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["displayIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.displayIndex ),
                x => m_InternalObject.displayIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Clear"] = new BSFunctionReference(
                new BSFunction(
                    "function Clear()",
                    a =>
                    {
                        m_InternalObject.Clear();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GridLayout : BSWrapperObject < GridLayout >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GridLayout( GridLayout obj ) : base( obj )
        {
            m_Properties["cellSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.cellSize ),
                null );

            m_Properties["cellGap"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.cellGap ),
                null );

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

            m_Properties["GetBoundsLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBoundsLocal(cellPosition)",
                    a => new BSWrapperObject_UnityEngine_Bounds(
                        m_InternalObject.GetBoundsLocal( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBoundsLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBoundsLocal(origin, size)",
                    a => new BSWrapperObject_UnityEngine_Bounds(
                        m_InternalObject.GetBoundsLocal(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ) ) ),
                    2 ) );

            m_Properties["CellToLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function CellToLocal(cellPosition)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.CellToLocal( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["LocalToCell"] = new BSFunctionReference(
                new BSFunction(
                    "function LocalToCell(localPosition)",
                    a => new BSWrapperObject_UnityEngine_Vector3Int(
                        m_InternalObject.LocalToCell( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["CellToLocalInterpolated"] = new BSFunctionReference(
                new BSFunction(
                    "function CellToLocalInterpolated(cellPosition)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.CellToLocalInterpolated( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["LocalToCellInterpolated"] = new BSFunctionReference(
                new BSFunction(
                    "function LocalToCellInterpolated(localPosition)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.LocalToCellInterpolated( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["CellToWorld"] = new BSFunctionReference(
                new BSFunction(
                    "function CellToWorld(cellPosition)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.CellToWorld( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["WorldToCell"] = new BSFunctionReference(
                new BSFunction(
                    "function WorldToCell(worldPosition)",
                    a => new BSWrapperObject_UnityEngine_Vector3Int(
                        m_InternalObject.WorldToCell( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["LocalToWorld"] = new BSFunctionReference(
                new BSFunction(
                    "function LocalToWorld(localPosition)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.LocalToWorld( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["WorldToLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function WorldToLocal(worldPosition)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.WorldToLocal( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

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

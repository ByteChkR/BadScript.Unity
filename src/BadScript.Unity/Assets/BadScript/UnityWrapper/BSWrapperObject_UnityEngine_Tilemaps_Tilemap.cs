using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Tilemaps_Tilemap : BSWrapperObject < Tilemap >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Tilemaps_Tilemap( Tilemap obj ) : base( obj )
        {
            m_Properties["layoutGrid"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Grid( m_InternalObject.layoutGrid ),
                null );

            m_Properties["cellBounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_BoundsInt( m_InternalObject.cellBounds ),
                null );

            m_Properties["localBounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.localBounds ),
                null );

            m_Properties["animationFrameRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.animationFrameRate ),
                x => m_InternalObject.animationFrameRate = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["origin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.origin ),
                x => m_InternalObject.origin = WrapperHelper.UnwrapObject < Vector3Int >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector3Int >( x ) );

            m_Properties["tileAnchor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.tileAnchor ),
                x => m_InternalObject.tileAnchor = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["orientationMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.orientationMatrix ),
                x => m_InternalObject.orientationMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["editorPreviewOrigin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.editorPreviewOrigin ),
                null );

            m_Properties["editorPreviewSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.editorPreviewSize ),
                null );

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

            m_Properties["GetCellCenterLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCellCenterLocal(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetCellCenterLocal( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetCellCenterWorld"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCellCenterWorld(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetCellCenterWorld( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTile"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTile(position)",
                    a => new BSWrapperObject_UnityEngine_Tilemaps_TileBase(
                        m_InternalObject.GetTile( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["HasTile"] = new BSFunctionReference(
                new BSFunction(
                    "function HasTile(position)",
                    a => m_InternalObject.HasTile( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ContainsTile"] = new BSFunctionReference(
                new BSFunction(
                    "function ContainsTile(tileAsset)",
                    a => m_InternalObject.ContainsTile( WrapperHelper.UnwrapObject < TileBase >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetSprite"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSprite(position)",
                    a => new BSWrapperObject_UnityEngine_Sprite(
                        m_InternalObject.GetSprite( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTransformMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTransformMatrix(position)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetTransformMatrix( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetColor(position)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetColor( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInstantiatedObject"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstantiatedObject(position)",
                    a => new BSWrapperObject_UnityEngine_GameObject(
                        m_InternalObject.GetInstantiatedObject( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetObjectToInstantiate"] = new BSFunctionReference(
                new BSFunction(
                    "function GetObjectToInstantiate(position)",
                    a => new BSWrapperObject_UnityEngine_GameObject(
                        m_InternalObject.GetObjectToInstantiate( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetEditorPreviewTile"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEditorPreviewTile(position)",
                    a => new BSWrapperObject_UnityEngine_Tilemaps_TileBase(
                        m_InternalObject.GetEditorPreviewTile( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["HasEditorPreviewTile"] = new BSFunctionReference(
                new BSFunction(
                    "function HasEditorPreviewTile(position)",
                    a => m_InternalObject.HasEditorPreviewTile( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetEditorPreviewSprite"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEditorPreviewSprite(position)",
                    a => new BSWrapperObject_UnityEngine_Sprite(
                        m_InternalObject.GetEditorPreviewSprite( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetEditorPreviewTransformMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEditorPreviewTransformMatrix(position)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetEditorPreviewTransformMatrix(
                            WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetEditorPreviewColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEditorPreviewColor(position)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetEditorPreviewColor( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

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

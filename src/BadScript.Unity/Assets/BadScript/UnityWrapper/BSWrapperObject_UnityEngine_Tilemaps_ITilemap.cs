using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Tilemaps_ITilemap : BSWrapperObject < ITilemap >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Tilemaps_ITilemap( ITilemap obj ) : base( obj )
        {
            m_Properties["origin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.origin ),
                null );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.size ),
                null );

            m_Properties["localBounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.localBounds ),
                null );

            m_Properties["cellBounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_BoundsInt( m_InternalObject.cellBounds ),
                null );

            m_Properties["GetSprite"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSprite(position)",
                    a => new BSWrapperObject_UnityEngine_Sprite(
                        m_InternalObject.GetSprite( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetColor(position)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetColor( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTransformMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTransformMatrix(position)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetTransformMatrix( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTile"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTile(position)",
                    a => new BSWrapperObject_UnityEngine_Tilemaps_TileBase(
                        m_InternalObject.GetTile( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) ) ),
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

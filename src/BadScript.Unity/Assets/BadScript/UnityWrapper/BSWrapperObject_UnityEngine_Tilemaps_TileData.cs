using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Tilemaps_TileData : BSWrapperObject < TileData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Tilemaps_TileData( TileData obj ) : base( obj )
        {
            m_Properties["sprite"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Sprite( m_InternalObject.sprite ),
                x => m_InternalObject.sprite = WrapperHelper.UnwrapObject < Sprite >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.transform ),
                x => m_InternalObject.transform = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                x => m_InternalObject.gameObject = WrapperHelper.UnwrapObject < GameObject >( x ) );

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

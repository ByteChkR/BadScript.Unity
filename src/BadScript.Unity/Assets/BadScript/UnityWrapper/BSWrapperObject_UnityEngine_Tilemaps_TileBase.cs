using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Tilemaps_TileBase : BSWrapperObject < TileBase >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Tilemaps_TileBase( TileBase obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["StartUp"] = new BSFunctionReference(
                new BSFunction(
                    "function StartUp(position, tilemap, go)",
                    a => m_InternalObject.StartUp(
                        WrapperHelper.UnwrapObject < Vector3Int >( a[0] ),
                        WrapperHelper.UnwrapObject < ITilemap >( a[1] ),
                        WrapperHelper.UnwrapObject < GameObject >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_WSA_Tile : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_WSA_Tile() : base( typeof( Tile ) )
        {
            m_StaticProperties["main"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_WSA_Tile( Tile.main ),
                null );

            m_StaticProperties["Exists"] = new BSFunctionReference(
                new BSFunction(
                    "function Exists(tileId)",
                    a => Tile.Exists( WrapperHelper.UnwrapObject < string >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["CreateOrUpdateSecondary"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateOrUpdateSecondary(data)",
                    a => new BSWrapperObject_UnityEngine_WSA_Tile(
                        Tile.CreateOrUpdateSecondary( WrapperHelper.UnwrapObject < SecondaryTileData >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CreateOrUpdateSecondary"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateOrUpdateSecondary(data, pos)",
                    a => new BSWrapperObject_UnityEngine_WSA_Tile(
                        Tile.CreateOrUpdateSecondary(
                            WrapperHelper.UnwrapObject < SecondaryTileData >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["CreateOrUpdateSecondary"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateOrUpdateSecondary(data, area)",
                    a => new BSWrapperObject_UnityEngine_WSA_Tile(
                        Tile.CreateOrUpdateSecondary(
                            WrapperHelper.UnwrapObject < SecondaryTileData >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetSecondary"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSecondary(tileId)",
                    a => new BSWrapperObject_UnityEngine_WSA_Tile(
                        Tile.GetSecondary( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

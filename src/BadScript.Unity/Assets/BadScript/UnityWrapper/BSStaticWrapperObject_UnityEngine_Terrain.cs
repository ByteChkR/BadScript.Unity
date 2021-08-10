using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Terrain : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Terrain() : base( typeof( Terrain ) )
        {
            m_StaticProperties["activeTerrain"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Terrain( Terrain.activeTerrain ),
                null );

            m_StaticProperties["CreateTerrainGameObject"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateTerrainGameObject(assignTerrain)",
                    a => new BSWrapperObject_UnityEngine_GameObject(
                        Terrain.CreateTerrainGameObject( WrapperHelper.UnwrapObject < TerrainData >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_TerrainData : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_TerrainData() : base( typeof( TerrainData ) )
        {
            m_StaticProperties["AlphamapTextureName"] = new BSReflectionReference(
                () => new BSObject( TerrainData.AlphamapTextureName ),
                null );

            m_StaticProperties["HolesTextureName"] = new BSReflectionReference(
                () => new BSObject( TerrainData.HolesTextureName ),
                null );

        }

        #endregion
    }

}

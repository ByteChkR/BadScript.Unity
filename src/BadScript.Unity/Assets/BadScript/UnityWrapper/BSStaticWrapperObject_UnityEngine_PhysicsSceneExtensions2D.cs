using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_PhysicsSceneExtensions2D : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_PhysicsSceneExtensions2D() : base( typeof( PhysicsSceneExtensions2D ) )
        {
            m_StaticProperties["GetPhysicsScene2D"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPhysicsScene2D(scene)",
                    a => new BSWrapperObject_UnityEngine_PhysicsScene2D(
                        PhysicsSceneExtensions2D.GetPhysicsScene2D( WrapperHelper.UnwrapObject < Scene >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

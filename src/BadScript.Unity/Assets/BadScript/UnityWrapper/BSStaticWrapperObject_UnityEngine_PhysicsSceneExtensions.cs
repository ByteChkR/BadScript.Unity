using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_PhysicsSceneExtensions : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_PhysicsSceneExtensions() : base( typeof( PhysicsSceneExtensions ) )
        {
            m_StaticProperties["GetPhysicsScene"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPhysicsScene(scene)",
                    a => new BSWrapperObject_UnityEngine_PhysicsScene(
                        PhysicsSceneExtensions.GetPhysicsScene( WrapperHelper.UnwrapObject < Scene >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

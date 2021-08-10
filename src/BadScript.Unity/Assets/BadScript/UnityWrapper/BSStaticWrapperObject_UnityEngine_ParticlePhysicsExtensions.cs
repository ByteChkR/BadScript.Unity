using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ParticlePhysicsExtensions : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ParticlePhysicsExtensions() : base(
            typeof( ParticlePhysicsExtensions ) )
        {
            m_StaticProperties["GetSafeCollisionEventSize"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSafeCollisionEventSize(ps)",
                    a => new BSObject(
                        ( decimal ) ParticlePhysicsExtensions.GetSafeCollisionEventSize(
                            WrapperHelper.UnwrapObject < ParticleSystem >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

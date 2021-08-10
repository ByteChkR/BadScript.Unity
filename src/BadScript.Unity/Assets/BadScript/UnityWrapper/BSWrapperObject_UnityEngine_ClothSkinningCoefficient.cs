using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ClothSkinningCoefficient : BSWrapperObject < ClothSkinningCoefficient >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ClothSkinningCoefficient( ClothSkinningCoefficient obj ) : base( obj )
        {
            m_Properties["maxDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxDistance ),
                x => m_InternalObject.maxDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["collisionSphereDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.collisionSphereDistance ),
                x => m_InternalObject.collisionSphereDistance = WrapperHelper.UnwrapObject < float >( x ) );

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

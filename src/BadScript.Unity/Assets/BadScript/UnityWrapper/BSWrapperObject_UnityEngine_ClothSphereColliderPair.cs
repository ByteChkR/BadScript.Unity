using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ClothSphereColliderPair : BSWrapperObject < ClothSphereColliderPair >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ClothSphereColliderPair( ClothSphereColliderPair obj ) : base( obj )
        {
            m_Properties["first"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SphereCollider( m_InternalObject.first ),
                x => m_InternalObject.first = WrapperHelper.UnwrapObject < SphereCollider >( x ) );

            m_Properties["second"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SphereCollider( m_InternalObject.second ),
                x => m_InternalObject.second = WrapperHelper.UnwrapObject < SphereCollider >( x ) );

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

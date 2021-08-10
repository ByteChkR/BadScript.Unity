using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_PhysicMaterial : BSWrapperObject < PhysicMaterial >

    {
        #region Public

        public BSWrapperObject_UnityEngine_PhysicMaterial( PhysicMaterial obj ) : base( obj )
        {
            m_Properties["bounciness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounciness ),
                x => m_InternalObject.bounciness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["dynamicFriction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dynamicFriction ),
                x => m_InternalObject.dynamicFriction = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["staticFriction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.staticFriction ),
                x => m_InternalObject.staticFriction = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bouncyness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounciness ),
                x => m_InternalObject.bounciness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

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

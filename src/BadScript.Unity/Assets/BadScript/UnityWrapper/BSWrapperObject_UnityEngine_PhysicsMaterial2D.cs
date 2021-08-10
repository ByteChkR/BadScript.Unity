using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_PhysicsMaterial2D : BSWrapperObject < PhysicsMaterial2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_PhysicsMaterial2D( PhysicsMaterial2D obj ) : base( obj )
        {
            m_Properties["bounciness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounciness ),
                x => m_InternalObject.bounciness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["friction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.friction ),
                x => m_InternalObject.friction = WrapperHelper.UnwrapObject < float >( x ) );

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

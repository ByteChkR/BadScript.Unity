using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animations_MuscleHandle : BSWrapperObject < MuscleHandle >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_MuscleHandle( MuscleHandle obj ) : base( obj )
        {
            m_Properties["dof"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dof ),
                null );

            m_Properties["name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.name ), null );

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

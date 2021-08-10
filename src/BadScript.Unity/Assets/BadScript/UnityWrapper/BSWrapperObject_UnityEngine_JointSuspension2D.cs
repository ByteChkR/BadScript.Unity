using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_JointSuspension2D : BSWrapperObject < JointSuspension2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_JointSuspension2D( JointSuspension2D obj ) : base( obj )
        {
            m_Properties["dampingRatio"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dampingRatio ),
                x => m_InternalObject.dampingRatio = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["frequency"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.frequency ),
                x => m_InternalObject.frequency = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["angle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angle ),
                x => m_InternalObject.angle = WrapperHelper.UnwrapObject < float >( x ) );

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

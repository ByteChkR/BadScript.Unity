using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_HumanBone : BSWrapperObject < HumanBone >

    {
        #region Public

        public BSWrapperObject_UnityEngine_HumanBone( HumanBone obj ) : base( obj )
        {
            m_Properties["boneName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.boneName ),
                x => m_InternalObject.boneName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["humanName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.humanName ),
                x => m_InternalObject.humanName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["limit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_HumanLimit( m_InternalObject.limit ),
                x => m_InternalObject.limit = WrapperHelper.UnwrapObject < HumanLimit >( x ) );

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

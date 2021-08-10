using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Motion : BSWrapperObject < Motion >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Motion( Motion obj ) : base( obj )
        {
            m_Properties["averageDuration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.averageDuration ),
                null );

            m_Properties["averageAngularSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.averageAngularSpeed ),
                null );

            m_Properties["averageSpeed"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.averageSpeed ),
                null );

            m_Properties["apparentSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.apparentSpeed ),
                null );

            m_Properties["isLooping"] = new BSReflectionReference(
                () => m_InternalObject.isLooping ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["legacy"] = new BSReflectionReference(
                () => m_InternalObject.legacy ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isHumanMotion"] = new BSReflectionReference(
                () => m_InternalObject.isHumanMotion ? BSObject.One : BSObject.Zero,
                null );

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

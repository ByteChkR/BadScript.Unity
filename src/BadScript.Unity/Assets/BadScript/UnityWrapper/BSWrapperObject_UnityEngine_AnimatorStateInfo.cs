using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AnimatorStateInfo : BSWrapperObject < AnimatorStateInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimatorStateInfo( AnimatorStateInfo obj ) : base( obj )
        {
            m_Properties["fullPathHash"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fullPathHash ),
                null );

            m_Properties["nameHash"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.nameHash ),
                null );

            m_Properties["shortNameHash"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shortNameHash ),
                null );

            m_Properties["normalizedTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.normalizedTime ),
                null );

            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
                null );

            m_Properties["speed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.speed ),
                null );

            m_Properties["speedMultiplier"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.speedMultiplier ),
                null );

            m_Properties["tagHash"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tagHash ),
                null );

            m_Properties["loop"] = new BSReflectionReference(
                () => m_InternalObject.loop ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsName"] = new BSFunctionReference(
                new BSFunction(
                    "function IsName(name)",
                    a => m_InternalObject.IsName( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsTag"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTag(tag)",
                    a => m_InternalObject.IsTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

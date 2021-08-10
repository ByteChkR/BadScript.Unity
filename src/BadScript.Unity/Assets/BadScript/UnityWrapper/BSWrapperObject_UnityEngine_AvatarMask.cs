using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AvatarMask : BSWrapperObject < AvatarMask >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AvatarMask( AvatarMask obj ) : base( obj )
        {
            m_Properties["humanoidBodyPartCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.humanoidBodyPartCount ),
                null );

            m_Properties["transformCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.transformCount ),
                x => m_InternalObject.transformCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetTransformPath"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTransformPath(index)",
                    a => new BSObject(
                        m_InternalObject.GetTransformPath( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTransformActive"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTransformActive(index)",
                    a => m_InternalObject.GetTransformActive( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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

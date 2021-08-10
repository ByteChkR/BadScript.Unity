using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Android;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Android_PermissionCallbacks : BSWrapperObject < PermissionCallbacks >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Android_PermissionCallbacks( PermissionCallbacks obj ) : base( obj )
        {
            m_Properties["javaInterface"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AndroidJavaClass( m_InternalObject.javaInterface ),
                null );

            m_Properties["equals"] = new BSFunctionReference(
                new BSFunction(
                    "function equals(obj)",
                    a => m_InternalObject.equals( WrapperHelper.UnwrapObject < AndroidJavaObject >( a[0] ) )
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

using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WSA_WindowSizeChanged : BSWrapperObject < WindowSizeChanged >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WSA_WindowSizeChanged( WindowSizeChanged obj ) : base( obj )
        {
            m_Properties["Method"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_MethodInfo( m_InternalObject.Method ),
                null );

            m_Properties["Target"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Target ),
                null );

            m_Properties["BeginInvoke"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginInvoke(width, height, callback, object)",
                    a => new BSWrapperObject_System_IAsyncResult(
                        m_InternalObject.BeginInvoke(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < AsyncCallback >( a[2] ),
                            WrapperHelper.UnwrapObject < object >( a[3] ) ) ),
                    4 ) );

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

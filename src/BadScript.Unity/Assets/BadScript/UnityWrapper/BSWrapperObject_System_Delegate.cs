using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Delegate : BSWrapperObject < Delegate >

    {
        #region Public

        public BSWrapperObject_System_Delegate( Delegate obj ) : base( obj )
        {
            m_Properties["Method"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_MethodInfo( m_InternalObject.Method ),
                null );

            m_Properties["Target"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Target ),
                null );

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

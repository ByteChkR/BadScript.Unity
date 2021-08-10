using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WaitWhile : BSWrapperObject < WaitWhile >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WaitWhile( WaitWhile obj ) : base( obj )
        {
            m_Properties["keepWaiting"] = new BSReflectionReference(
                () => m_InternalObject.keepWaiting ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Current"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Current ),
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

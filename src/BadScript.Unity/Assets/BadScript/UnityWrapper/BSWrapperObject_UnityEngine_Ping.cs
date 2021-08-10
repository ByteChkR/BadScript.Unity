using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Ping : BSWrapperObject < Ping >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Ping( Ping obj ) : base( obj )
        {
            m_Properties["isDone"] = new BSReflectionReference(
                () => m_InternalObject.isDone ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                null );

            m_Properties["ip"] = new BSReflectionReference( () => new BSObject( m_InternalObject.ip ), null );

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

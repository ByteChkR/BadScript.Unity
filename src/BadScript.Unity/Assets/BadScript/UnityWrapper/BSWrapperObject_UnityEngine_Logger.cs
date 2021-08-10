using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Logger : BSWrapperObject < Logger >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Logger( Logger obj ) : base( obj )
        {
            m_Properties["logHandler"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ILogHandler( m_InternalObject.logHandler ),
                x => m_InternalObject.logHandler = WrapperHelper.UnwrapObject < ILogHandler >( x ) );

            m_Properties["logEnabled"] = new BSReflectionReference(
                () => m_InternalObject.logEnabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.logEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

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

using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ILogger : BSWrapperObject < ILogger >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ILogger( ILogger obj ) : base( obj )
        {
            m_Properties["logHandler"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ILogHandler( m_InternalObject.logHandler ),
                x => m_InternalObject.logHandler = WrapperHelper.UnwrapObject < ILogHandler >( x ) );

            m_Properties["logEnabled"] = new BSReflectionReference(
                () => m_InternalObject.logEnabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.logEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}

using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using Object = UnityEngine.Object;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_ILogHandler : BSWrapperObject < ILogHandler >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ILogHandler( ILogHandler obj ) : base( obj )
        {
            m_Properties["LogException"] = new BSFunctionReference(
                new BSFunction(
                    "function LogException(exception, context)",
                    a =>
                    {
                        m_InternalObject.LogException(
                            WrapperHelper.UnwrapObject < Exception >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

        }

        #endregion
    }

}

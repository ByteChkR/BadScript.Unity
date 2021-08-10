using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.LowLevel;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LowLevel_PlayerLoopSystem : BSWrapperObject < PlayerLoopSystem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LowLevel_PlayerLoopSystem( PlayerLoopSystem obj ) : base( obj )
        {
            m_Properties["updateFunction"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( m_InternalObject.updateFunction ),
                x => m_InternalObject.updateFunction = WrapperHelper.UnwrapObject < IntPtr >( x ) );

            m_Properties["loopConditionFunction"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( m_InternalObject.loopConditionFunction ),
                x => m_InternalObject.loopConditionFunction = WrapperHelper.UnwrapObject < IntPtr >( x ) );

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

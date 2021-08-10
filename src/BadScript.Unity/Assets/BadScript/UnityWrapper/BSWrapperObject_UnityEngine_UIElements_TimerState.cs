using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_TimerState : BSWrapperObject < TimerState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_TimerState( TimerState obj ) : base( obj )
        {
            m_Properties["start"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.start ),
                x => m_InternalObject.start = WrapperHelper.UnwrapObject < long >( x ) );

            m_Properties["now"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.now ),
                x => m_InternalObject.now = WrapperHelper.UnwrapObject < long >( x ) );

            m_Properties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.deltaTime ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < TimerState >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

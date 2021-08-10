using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SubsystemsImplementation;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemProvider : BSWrapperObject < SubsystemProvider >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemProvider( SubsystemProvider obj ) : base(
            obj )
        {
            m_Properties["running"] = new BSReflectionReference(
                () => m_InternalObject.running ? BSObject.One : BSObject.Zero,
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

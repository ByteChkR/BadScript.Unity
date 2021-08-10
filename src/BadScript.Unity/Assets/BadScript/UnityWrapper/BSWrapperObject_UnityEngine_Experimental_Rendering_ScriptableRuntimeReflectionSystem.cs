using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Experimental.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystem : BSWrapperObject <
            ScriptableRuntimeReflectionSystem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystem(
            ScriptableRuntimeReflectionSystem obj ) : base( obj )
        {
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

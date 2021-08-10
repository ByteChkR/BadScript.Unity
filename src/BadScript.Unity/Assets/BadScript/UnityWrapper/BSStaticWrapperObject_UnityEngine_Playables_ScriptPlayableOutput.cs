using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Playables_ScriptPlayableOutput : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Playables_ScriptPlayableOutput() : base(
            typeof( ScriptPlayableOutput ) )
        {
            m_StaticProperties["Null"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Playables_ScriptPlayableOutput( ScriptPlayableOutput.Null ),
                null );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, name)",
                    a => new BSWrapperObject_UnityEngine_Playables_ScriptPlayableOutput(
                        ScriptPlayableOutput.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows.Speech;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Windows_Speech_KeywordRecognizer : BSWrapperObject < KeywordRecognizer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Windows_Speech_KeywordRecognizer( KeywordRecognizer obj ) : base( obj )
        {
            m_Properties["IsRunning"] = new BSReflectionReference(
                () => m_InternalObject.IsRunning ? BSObject.One : BSObject.Zero,
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

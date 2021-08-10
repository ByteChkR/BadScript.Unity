using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows.Speech;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Windows_Speech_PhraseRecognitionSystem : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Windows_Speech_PhraseRecognitionSystem() : base(
            typeof( PhraseRecognitionSystem ) )
        {
            m_StaticProperties["isSupported"] = new BSReflectionReference(
                () => PhraseRecognitionSystem.isSupported ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

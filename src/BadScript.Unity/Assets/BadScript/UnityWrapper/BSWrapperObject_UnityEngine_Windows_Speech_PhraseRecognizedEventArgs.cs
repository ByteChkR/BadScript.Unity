using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows.Speech;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Windows_Speech_PhraseRecognizedEventArgs : BSWrapperObject <
            PhraseRecognizedEventArgs >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Windows_Speech_PhraseRecognizedEventArgs( PhraseRecognizedEventArgs obj ) :
            base( obj )
        {
            m_Properties["text"] = new BSReflectionReference( () => new BSObject( m_InternalObject.text ), null );

            m_Properties["phraseStartTime"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( m_InternalObject.phraseStartTime ),
                null );

            m_Properties["phraseDuration"] = new BSReflectionReference(
                () => new BSWrapperObject_System_TimeSpan( m_InternalObject.phraseDuration ),
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

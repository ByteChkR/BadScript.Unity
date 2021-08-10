using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows.Speech;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Windows_Speech_DictationRecognizer : BSWrapperObject < DictationRecognizer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Windows_Speech_DictationRecognizer( DictationRecognizer obj ) : base( obj )
        {
            m_Properties["AutoSilenceTimeoutSeconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.AutoSilenceTimeoutSeconds ),
                x => m_InternalObject.AutoSilenceTimeoutSeconds = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["InitialSilenceTimeoutSeconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.InitialSilenceTimeoutSeconds ),
                x => m_InternalObject.InitialSilenceTimeoutSeconds = WrapperHelper.UnwrapObject < float >( x ) );

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

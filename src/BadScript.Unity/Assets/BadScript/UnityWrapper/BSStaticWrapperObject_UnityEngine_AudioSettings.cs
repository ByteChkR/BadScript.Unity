using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AudioSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AudioSettings() : base( typeof( AudioSettings ) )
        {
            m_StaticProperties["dspTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AudioSettings.dspTime ),
                null );

            m_StaticProperties["outputSampleRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AudioSettings.outputSampleRate ),
                x => AudioSettings.outputSampleRate = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["Reset"] = new BSFunctionReference(
                new BSFunction(
                    "function Reset(config)",
                    a => AudioSettings.Reset( WrapperHelper.UnwrapObject < AudioConfiguration >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

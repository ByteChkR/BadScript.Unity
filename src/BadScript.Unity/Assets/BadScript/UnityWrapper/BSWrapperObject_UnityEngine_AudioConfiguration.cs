using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AudioConfiguration : BSWrapperObject < AudioConfiguration >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AudioConfiguration( AudioConfiguration obj ) : base( obj )
        {
            m_Properties["dspBufferSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dspBufferSize ),
                x => m_InternalObject.dspBufferSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sampleRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sampleRate ),
                x => m_InternalObject.sampleRate = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["numRealVoices"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.numRealVoices ),
                x => m_InternalObject.numRealVoices = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["numVirtualVoices"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.numVirtualVoices ),
                x => m_InternalObject.numVirtualVoices = WrapperHelper.UnwrapObject < int >( x ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_XR_HapticCapabilities : BSWrapperObject < HapticCapabilities >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_HapticCapabilities( HapticCapabilities obj ) : base( obj )
        {
            m_Properties["numChannels"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.numChannels ),
                null );

            m_Properties["supportsImpulse"] = new BSReflectionReference(
                () => m_InternalObject.supportsImpulse ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["supportsBuffer"] = new BSReflectionReference(
                () => m_InternalObject.supportsBuffer ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["bufferFrequencyHz"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bufferFrequencyHz ),
                null );

            m_Properties["bufferMaxSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bufferMaxSize ),
                null );

            m_Properties["bufferOptimalSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bufferOptimalSize ),
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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < HapticCapabilities >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

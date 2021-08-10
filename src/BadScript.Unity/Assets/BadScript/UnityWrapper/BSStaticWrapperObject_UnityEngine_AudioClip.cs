using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AudioClip : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AudioClip() : base( typeof( AudioClip ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(name, lengthSamples, channels, frequency, _3D, stream)",
                    a => new BSWrapperObject_UnityEngine_AudioClip(
                        AudioClip.Create(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < bool >( a[4] ),
                            WrapperHelper.UnwrapObject < bool >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(name, lengthSamples, channels, frequency, stream)",
                    a => new BSWrapperObject_UnityEngine_AudioClip(
                        AudioClip.Create(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < bool >( a[4] ) ) ),
                    5 ) );

        }

        #endregion
    }

}

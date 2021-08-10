using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Microphone : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Microphone() : base( typeof( Microphone ) )
        {
            m_StaticProperties["Start"] = new BSFunctionReference(
                new BSFunction(
                    "function Start(deviceName, loop, lengthSec, frequency)",
                    a => new BSWrapperObject_UnityEngine_AudioClip(
                        Microphone.Start(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["IsRecording"] = new BSFunctionReference(
                new BSFunction(
                    "function IsRecording(deviceName)",
                    a => Microphone.IsRecording( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetPosition"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPosition(deviceName)",
                    a => new BSObject(
                        ( decimal ) Microphone.GetPosition( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

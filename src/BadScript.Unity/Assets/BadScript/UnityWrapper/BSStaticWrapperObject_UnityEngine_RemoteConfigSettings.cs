using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_RemoteConfigSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_RemoteConfigSettings() : base( typeof( RemoteConfigSettings ) )
        {
            m_StaticProperties["QueueConfig"] = new BSFunctionReference(
                new BSFunction(
                    "function QueueConfig(name, param, ver, prefix)",
                    a => RemoteConfigSettings.QueueConfig(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < object >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < string >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

        }

        #endregion
    }

}

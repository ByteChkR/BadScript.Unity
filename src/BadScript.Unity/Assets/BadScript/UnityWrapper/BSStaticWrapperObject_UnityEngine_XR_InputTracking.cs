using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_XR_InputTracking : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_XR_InputTracking() : base( typeof( InputTracking ) )
        {
            m_StaticProperties["disablePositionalTracking"] = new BSReflectionReference(
                () => InputTracking.disablePositionalTracking ? BSObject.One : BSObject.Zero,
                x => InputTracking.disablePositionalTracking = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["GetNodeName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNodeName(uniqueId)",
                    a => new BSObject( InputTracking.GetNodeName( WrapperHelper.UnwrapObject < ulong >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

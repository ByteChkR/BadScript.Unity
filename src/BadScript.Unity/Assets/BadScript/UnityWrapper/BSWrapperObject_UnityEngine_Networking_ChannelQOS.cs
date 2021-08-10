using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_ChannelQOS : BSWrapperObject < ChannelQOS >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_ChannelQOS( ChannelQOS obj ) : base( obj )
        {
            m_Properties["BelongsToSharedOrderChannel"] = new BSReflectionReference(
                () => m_InternalObject.BelongsToSharedOrderChannel ? BSObject.One : BSObject.Zero,
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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_Local : BSWrapperObject < Local >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_Local( Local obj ) : base( obj )
        {
            m_Properties["localUser"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SocialPlatforms_ILocalUser( m_InternalObject.localUser ),
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

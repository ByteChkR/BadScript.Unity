using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_Range : BSWrapperObject < Range >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_Range( Range obj ) : base( obj )
        {
            m_Properties["from"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.from ),
                x => m_InternalObject.from = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["count"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.count ),
                x => m_InternalObject.count = WrapperHelper.UnwrapObject < int >( x ) );

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

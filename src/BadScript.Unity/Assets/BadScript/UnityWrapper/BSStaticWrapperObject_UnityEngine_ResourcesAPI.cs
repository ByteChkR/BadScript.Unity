using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ResourcesAPI : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ResourcesAPI() : base( typeof( ResourcesAPI ) )
        {
            m_StaticProperties["overrideAPI"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ResourcesAPI( ResourcesAPI.overrideAPI ),
                x => ResourcesAPI.overrideAPI = WrapperHelper.UnwrapObject < ResourcesAPI >( x ) );

        }

        #endregion
    }

}

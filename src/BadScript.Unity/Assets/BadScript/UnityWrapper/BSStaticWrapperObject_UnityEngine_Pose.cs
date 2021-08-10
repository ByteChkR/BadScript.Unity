using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Pose : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Pose() : base( typeof( Pose ) )
        {
            m_StaticProperties["identity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Pose( Pose.identity ),
                null );

        }

        #endregion
    }

}

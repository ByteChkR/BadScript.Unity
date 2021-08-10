using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.iOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_iOS_LocalNotification : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_iOS_LocalNotification() : base( typeof( LocalNotification ) )
        {
            m_StaticProperties["defaultSoundName"] = new BSReflectionReference(
                () => new BSObject( LocalNotification.defaultSoundName ),
                null );

        }

        #endregion
    }

}

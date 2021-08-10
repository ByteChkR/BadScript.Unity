using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_System : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_System() : base(
            typeof( UnityEngine.Rendering.VirtualTexturing.System ) )
        {
            m_StaticProperties["AllMips"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) UnityEngine.Rendering.VirtualTexturing.System.AllMips ),
                null );

        }

        #endregion
    }

}

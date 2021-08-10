using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Animations_MuscleHandle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Animations_MuscleHandle() : base( typeof( MuscleHandle ) )
        {
            m_StaticProperties["muscleHandleCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) MuscleHandle.muscleHandleCount ),
                null );

        }

        #endregion
    }

}

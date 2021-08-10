using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements.Experimental;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_UIElements_Experimental_IValueAnimation : BSWrapperObject < IValueAnimation >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_Experimental_IValueAnimation( IValueAnimation obj ) : base( obj )
        {
            m_Properties["isRunning"] = new BSReflectionReference(
                () => m_InternalObject.isRunning ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["durationMs"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.durationMs ),
                x => m_InternalObject.durationMs = WrapperHelper.UnwrapObject < int >( x ) );

        }

        #endregion
    }

}

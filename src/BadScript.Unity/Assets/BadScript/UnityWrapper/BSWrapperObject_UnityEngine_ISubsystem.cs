using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ISubsystem : BSWrapperObject < ISubsystem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ISubsystem( ISubsystem obj ) : base( obj )
        {
            m_Properties["running"] = new BSReflectionReference(
                () => m_InternalObject.running ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}

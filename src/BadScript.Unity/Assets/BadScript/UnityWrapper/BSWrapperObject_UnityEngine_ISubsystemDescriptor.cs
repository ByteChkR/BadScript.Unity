using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ISubsystemDescriptor : BSWrapperObject < ISubsystemDescriptor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ISubsystemDescriptor( ISubsystemDescriptor obj ) : base( obj )
        {
            m_Properties["id"] = new BSReflectionReference( () => new BSObject( m_InternalObject.id ), null );

        }

        #endregion
    }

}

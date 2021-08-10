using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.VFX;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_VFX_VFXOutputEventArgs : BSWrapperObject < VFXOutputEventArgs >

    {
        #region Public

        public BSWrapperObject_UnityEngine_VFX_VFXOutputEventArgs( VFXOutputEventArgs obj ) : base( obj )
        {
            m_Properties["nameId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.nameId ),
                null );

            m_Properties["eventAttribute"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_VFX_VFXEventAttribute( m_InternalObject.eventAttribute ),
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

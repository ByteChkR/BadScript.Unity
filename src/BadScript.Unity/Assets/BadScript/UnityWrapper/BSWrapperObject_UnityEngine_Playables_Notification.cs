using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Playables_Notification : BSWrapperObject < Notification >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_Notification( Notification obj ) : base( obj )
        {
            m_Properties["id"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PropertyName( m_InternalObject.id ),
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

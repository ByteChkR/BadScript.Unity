using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_IBindable : BSWrapperObject < IBindable >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IBindable( IBindable obj ) : base( obj )
        {
            m_Properties["binding"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IBinding( m_InternalObject.binding ),
                x => m_InternalObject.binding = WrapperHelper.UnwrapObject < IBinding >( x ) );

            m_Properties["bindingPath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.bindingPath ),
                x => m_InternalObject.bindingPath = WrapperHelper.UnwrapObject < string >( x ) );

        }

        #endregion
    }

}

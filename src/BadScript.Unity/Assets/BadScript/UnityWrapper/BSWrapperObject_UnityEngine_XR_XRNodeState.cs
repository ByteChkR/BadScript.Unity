using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_XR_XRNodeState : BSWrapperObject < XRNodeState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_XRNodeState( XRNodeState obj ) : base( obj )
        {
            m_Properties["uniqueID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.uniqueID ),
                x => m_InternalObject.uniqueID = WrapperHelper.UnwrapObject < ulong >( x ) );

            m_Properties["tracked"] = new BSReflectionReference(
                () => m_InternalObject.tracked ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.tracked = WrapperHelper.UnwrapObject < bool >( x ) );

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

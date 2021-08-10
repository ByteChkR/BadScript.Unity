using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SoftJointLimit : BSWrapperObject < SoftJointLimit >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SoftJointLimit( SoftJointLimit obj ) : base( obj )
        {
            m_Properties["limit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.limit ),
                x => m_InternalObject.limit = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bounciness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounciness ),
                x => m_InternalObject.bounciness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["contactDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.contactDistance ),
                x => m_InternalObject.contactDistance = WrapperHelper.UnwrapObject < float >( x ) );

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

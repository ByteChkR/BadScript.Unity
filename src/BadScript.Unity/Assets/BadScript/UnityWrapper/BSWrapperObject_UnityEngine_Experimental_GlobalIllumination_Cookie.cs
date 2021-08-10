using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_Cookie : BSWrapperObject < Cookie >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_Cookie( Cookie obj ) : base( obj )
        {
            m_Properties["instanceID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.instanceID ),
                x => m_InternalObject.instanceID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["scale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scale ),
                x => m_InternalObject.scale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["sizes"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.sizes ),
                x => m_InternalObject.sizes = WrapperHelper.UnwrapObject < Vector2 >( x ) );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LightDataGI : BSWrapperObject < LightDataGI >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LightDataGI( LightDataGI obj ) : base( obj )
        {
            m_Properties["instanceID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.instanceID ),
                x => m_InternalObject.instanceID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["cookieID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cookieID ),
                x => m_InternalObject.cookieID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["cookieScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cookieScale ),
                x => m_InternalObject.cookieScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor(
                    m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < LinearColor >( x ) );

            m_Properties["indirectColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor(
                    m_InternalObject.indirectColor ),
                x => m_InternalObject.indirectColor = WrapperHelper.UnwrapObject < LinearColor >( x ) );

            m_Properties["orientation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.orientation ),
                x => m_InternalObject.orientation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["range"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.range ),
                x => m_InternalObject.range = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["coneAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.coneAngle ),
                x => m_InternalObject.coneAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["innerConeAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.innerConeAngle ),
                x => m_InternalObject.innerConeAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["shape0"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shape0 ),
                x => m_InternalObject.shape0 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["shape1"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shape1 ),
                x => m_InternalObject.shape1 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["shadow"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadow ),
                x => m_InternalObject.shadow = WrapperHelper.UnwrapObject < byte >( x ) );

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

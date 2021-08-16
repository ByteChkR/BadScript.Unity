using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_LocationInfo : BSWrapperObject < LocationInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LocationInfo( LocationInfo obj ) : base( obj )
        {
            m_Properties["latitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.latitude ),
                null );

            m_Properties["longitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.longitude ),
                null );

            m_Properties["altitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.altitude ),
                null );

            m_Properties["horizontalAccuracy"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.horizontalAccuracy ),
                null );

            m_Properties["verticalAccuracy"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.verticalAccuracy ),
                null );

            m_Properties["timestamp"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.timestamp ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}

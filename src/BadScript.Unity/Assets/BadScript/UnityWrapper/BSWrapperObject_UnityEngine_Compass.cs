using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Compass : BSWrapperObject < Compass >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Compass( Compass obj ) : base( obj )
        {
            m_Properties["magneticHeading"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.magneticHeading ),
                null );

            m_Properties["trueHeading"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.trueHeading ),
                null );

            m_Properties["headingAccuracy"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.headingAccuracy ),
                null );

            m_Properties["rawVector"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.rawVector ),
                null );

            m_Properties["timestamp"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.timestamp ),
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

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

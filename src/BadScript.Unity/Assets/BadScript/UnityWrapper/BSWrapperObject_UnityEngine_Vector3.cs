using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Vector3 : BSWrapperObject < Vector3 >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Vector3( Vector3 obj ) : base( obj )
        {
            m_Properties["normalized"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.normalized ),
                null );

            m_Properties["magnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.magnitude ),
                null );

            m_Properties["sqrMagnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sqrMagnitude ),
                null );

            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["z"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.z ),
                x => m_InternalObject.z = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format)",
                    a => new BSObject( m_InternalObject.ToString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format, formatProvider)",
                    a => new BSObject(
                        m_InternalObject.ToString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

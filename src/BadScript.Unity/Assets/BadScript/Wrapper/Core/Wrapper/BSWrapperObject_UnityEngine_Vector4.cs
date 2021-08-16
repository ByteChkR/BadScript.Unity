using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Vector4 : BSWrapperObject < Vector4 >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Vector4( Vector4 obj ) : base( obj )
        {
            m_Properties["normalized"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.normalized ),
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

            m_Properties["w"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.w ),
                x => m_InternalObject.w = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["Set"] = new BSFunctionReference(
                new BSFunction(
                    "function Set(newX, newY, newZ, newW)",
                    a =>
                    {
                        m_InternalObject.Set(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["Scale"] = new BSFunctionReference(
                new BSFunction(
                    "function Scale(scale)",
                    a =>
                    {
                        m_InternalObject.Scale( WrapperHelper.UnwrapObject < Vector4 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Vector4 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Normalize"] = new BSFunctionReference(
                new BSFunction(
                    "function Normalize()",
                    a =>
                    {
                        m_InternalObject.Normalize();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

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

            m_Properties["SqrMagnitude"] = new BSFunctionReference(
                new BSFunction(
                    "function SqrMagnitude()",
                    a => new BSObject( ( decimal ) m_InternalObject.SqrMagnitude() ),
                    0 ) );

        }

        #endregion
    }

}

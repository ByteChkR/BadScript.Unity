using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Color : BSWrapperObject < Color >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Color( Color obj ) : base( obj )
        {
            m_Properties["grayscale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.grayscale ),
                null );

            m_Properties["linear"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.linear ),
                null );

            m_Properties["gamma"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.gamma ),
                null );

            m_Properties["maxColorComponent"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxColorComponent ),
                null );

            m_Properties["get_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function get_Item(index)",
                    a => new BSObject( ( decimal ) m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] ),
                    1 ) );

            m_Properties["set_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function set_Item(index, value)",
                    a =>
                    {
                        m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] =
                            WrapperHelper.UnwrapObject < float >( a[1] );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["r"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.r ),
                x => m_InternalObject.r = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["g"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.g ),
                x => m_InternalObject.g = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["b"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.b ),
                x => m_InternalObject.b = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["a"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.a ),
                x => m_InternalObject.a = WrapperHelper.UnwrapObject < float >( x ) );

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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Color >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

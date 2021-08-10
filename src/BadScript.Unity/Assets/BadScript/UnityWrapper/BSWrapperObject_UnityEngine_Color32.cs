using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Color32 : BSWrapperObject < Color32 >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Color32( Color32 obj ) : base( obj )
        {
            m_Properties["r"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.r ),
                x => m_InternalObject.r = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["g"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.g ),
                x => m_InternalObject.g = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["b"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.b ),
                x => m_InternalObject.b = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["a"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.a ),
                x => m_InternalObject.a = WrapperHelper.UnwrapObject < byte >( x ) );

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

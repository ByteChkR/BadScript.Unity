using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Vector2Int : BSWrapperObject < Vector2Int >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Vector2Int( Vector2Int obj ) : base( obj )
        {
            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < int >( x ) );

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
                            WrapperHelper.UnwrapObject < int >( a[1] );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["magnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.magnitude ),
                null );

            m_Properties["sqrMagnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sqrMagnitude ),
                null );

            m_Properties["Set"] = new BSFunctionReference(
                new BSFunction(
                    "function Set(x, y)",
                    a =>
                    {
                        m_InternalObject.Set(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Scale"] = new BSFunctionReference(
                new BSFunction(
                    "function Scale(scale)",
                    a =>
                    {
                        m_InternalObject.Scale( WrapperHelper.UnwrapObject < Vector2Int >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Clamp"] = new BSFunctionReference(
                new BSFunction(
                    "function Clamp(min, max)",
                    a =>
                    {
                        m_InternalObject.Clamp(
                            WrapperHelper.UnwrapObject < Vector2Int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2Int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Vector2Int >( a[0] ) )
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

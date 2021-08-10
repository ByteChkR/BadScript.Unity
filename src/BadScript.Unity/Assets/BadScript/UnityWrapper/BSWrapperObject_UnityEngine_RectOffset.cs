using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_RectOffset : BSWrapperObject < RectOffset >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RectOffset( RectOffset obj ) : base( obj )
        {
            m_Properties["left"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.left ),
                x => m_InternalObject.left = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.right ),
                x => m_InternalObject.right = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["top"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.top ),
                x => m_InternalObject.top = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["bottom"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bottom ),
                x => m_InternalObject.bottom = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["horizontal"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.horizontal ),
                null );

            m_Properties["vertical"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertical ),
                null );

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

            m_Properties["Add"] = new BSFunctionReference(
                new BSFunction(
                    "function Add(rect)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        m_InternalObject.Add( WrapperHelper.UnwrapObject < Rect >( a[0] ) ) ),
                    1 ) );

            m_Properties["Remove"] = new BSFunctionReference(
                new BSFunction(
                    "function Remove(rect)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        m_InternalObject.Remove( WrapperHelper.UnwrapObject < Rect >( a[0] ) ) ),
                    1 ) );

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

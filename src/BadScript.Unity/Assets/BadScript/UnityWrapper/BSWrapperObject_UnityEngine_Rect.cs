using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rect : BSWrapperObject < Rect >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rect( Rect obj ) : base( obj )
        {
            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["min"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.min ),
                x => m_InternalObject.min = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["max"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.max ),
                x => m_InternalObject.max = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["xMin"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.xMin ),
                x => m_InternalObject.xMin = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["yMin"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.yMin ),
                x => m_InternalObject.yMin = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["xMax"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.xMax ),
                x => m_InternalObject.xMax = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["yMax"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.yMax ),
                x => m_InternalObject.yMax = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["left"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.left ),
                null );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.right ),
                null );

            m_Properties["top"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.top ),
                null );

            m_Properties["bottom"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bottom ),
                null );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point, allowInverse)",
                    a => m_InternalObject.Contains(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["Overlaps"] = new BSFunctionReference(
                new BSFunction(
                    "function Overlaps(other)",
                    a => m_InternalObject.Overlaps( WrapperHelper.UnwrapObject < Rect >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Overlaps"] = new BSFunctionReference(
                new BSFunction(
                    "function Overlaps(other, allowInverse)",
                    a => m_InternalObject.Overlaps(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Rect >( a[0] ) )
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

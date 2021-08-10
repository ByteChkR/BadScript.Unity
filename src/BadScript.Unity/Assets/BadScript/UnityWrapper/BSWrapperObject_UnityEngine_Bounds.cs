using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Bounds : BSWrapperObject < Bounds >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Bounds( Bounds obj ) : base( obj )
        {
            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["extents"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.extents ),
                x => m_InternalObject.extents = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["min"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.min ),
                x => m_InternalObject.min = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["max"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.max ),
                x => m_InternalObject.max = WrapperHelper.UnwrapObject < Vector3 >( x ) );

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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Bounds >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Intersects"] = new BSFunctionReference(
                new BSFunction(
                    "function Intersects(bounds)",
                    a => m_InternalObject.Intersects( WrapperHelper.UnwrapObject < Bounds >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IntersectRay"] = new BSFunctionReference(
                new BSFunction(
                    "function IntersectRay(ray)",
                    a => m_InternalObject.IntersectRay( WrapperHelper.UnwrapObject < Ray >( a[0] ) )
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

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(point)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["SqrDistance"] = new BSFunctionReference(
                new BSFunction(
                    "function SqrDistance(point)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.SqrDistance( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(point)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.ClosestPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Plane : BSWrapperObject < Plane >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Plane( Plane obj ) : base( obj )
        {
            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.normal ),
                x => m_InternalObject.normal = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["distance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distance ),
                x => m_InternalObject.distance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["flipped"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Plane( m_InternalObject.flipped ),
                null );

            m_Properties["ClosestPointOnPlane"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPointOnPlane(point)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.ClosestPointOnPlane( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetDistanceToPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDistanceToPoint(point)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetDistanceToPoint(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSide"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSide(point)",
                    a => m_InternalObject.GetSide( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["SameSide"] = new BSFunctionReference(
                new BSFunction(
                    "function SameSide(inPt0, inPt1)",
                    a => m_InternalObject.SameSide(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

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

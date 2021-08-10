using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_BoundsInt : BSWrapperObject < BoundsInt >

    {
        #region Public

        public BSWrapperObject_UnityEngine_BoundsInt( BoundsInt obj ) : base( obj )
        {
            m_Properties["x"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.x ),
                x => m_InternalObject.x = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["y"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.y ),
                x => m_InternalObject.y = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["z"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.z ),
                x => m_InternalObject.z = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.center ),
                null );

            m_Properties["min"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.min ),
                x => m_InternalObject.min = WrapperHelper.UnwrapObject < Vector3Int >( x ) );

            m_Properties["max"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.max ),
                x => m_InternalObject.max = WrapperHelper.UnwrapObject < Vector3Int >( x ) );

            m_Properties["xMin"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.xMin ),
                x => m_InternalObject.xMin = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["yMin"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.yMin ),
                x => m_InternalObject.yMin = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["zMin"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.zMin ),
                x => m_InternalObject.zMin = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["xMax"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.xMax ),
                x => m_InternalObject.xMax = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["yMax"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.yMax ),
                x => m_InternalObject.yMax = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["zMax"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.zMax ),
                x => m_InternalObject.zMax = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3Int >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3Int( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector3Int >( x ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(position)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < Vector3Int >( a[0] ) )
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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < BoundsInt >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

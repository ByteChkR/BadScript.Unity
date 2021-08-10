using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_jvalue : BSWrapperObject < jvalue >

    {
        #region Public

        public BSWrapperObject_UnityEngine_jvalue( jvalue obj ) : base( obj )
        {
            m_Properties["z"] = new BSReflectionReference(
                () => m_InternalObject.z ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.z = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["b"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.b ),
                x => m_InternalObject.b = WrapperHelper.UnwrapObject < sbyte >( x ) );

            m_Properties["c"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Char( m_InternalObject.c ),
                x => m_InternalObject.c = WrapperHelper.UnwrapObject < char >( x ) );

            m_Properties["s"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.s ),
                x => m_InternalObject.s = WrapperHelper.UnwrapObject < short >( x ) );

            m_Properties["i"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.i ),
                x => m_InternalObject.i = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["j"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.j ),
                x => m_InternalObject.j = WrapperHelper.UnwrapObject < long >( x ) );

            m_Properties["f"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.f ),
                x => m_InternalObject.f = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["d"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.d ),
                x => m_InternalObject.d = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["l"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( m_InternalObject.l ),
                x => m_InternalObject.l = WrapperHelper.UnwrapObject < IntPtr >( x ) );

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

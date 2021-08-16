using System;
using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_MethodBase : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Reflection_MethodBase() : base( typeof( MethodBase ) )
        {
            m_StaticProperties["GetMethodFromHandle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMethodFromHandle(handle)",
                    a => new BSWrapperObject_System_Reflection_MethodBase(
                        MethodBase.GetMethodFromHandle( WrapperHelper.UnwrapObject < RuntimeMethodHandle >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetMethodFromHandle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMethodFromHandle(handle, declaringType)",
                    a => new BSWrapperObject_System_Reflection_MethodBase(
                        MethodBase.GetMethodFromHandle(
                            WrapperHelper.UnwrapObject < RuntimeMethodHandle >( a[0] ),
                            WrapperHelper.UnwrapObject < RuntimeTypeHandle >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetCurrentMethod"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCurrentMethod()",
                    a => new BSWrapperObject_System_Reflection_MethodBase( MethodBase.GetCurrentMethod() ),
                    0 ) );

        }

        #endregion
    }

}

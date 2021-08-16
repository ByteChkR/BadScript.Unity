using System;
using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_FieldInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Reflection_FieldInfo() : base( typeof( FieldInfo ) )
        {
            m_StaticProperties["GetFieldFromHandle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFieldFromHandle(handle)",
                    a => new BSWrapperObject_System_Reflection_FieldInfo(
                        FieldInfo.GetFieldFromHandle( WrapperHelper.UnwrapObject < RuntimeFieldHandle >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetFieldFromHandle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFieldFromHandle(handle, declaringType)",
                    a => new BSWrapperObject_System_Reflection_FieldInfo(
                        FieldInfo.GetFieldFromHandle(
                            WrapperHelper.UnwrapObject < RuntimeFieldHandle >( a[0] ),
                            WrapperHelper.UnwrapObject < RuntimeTypeHandle >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

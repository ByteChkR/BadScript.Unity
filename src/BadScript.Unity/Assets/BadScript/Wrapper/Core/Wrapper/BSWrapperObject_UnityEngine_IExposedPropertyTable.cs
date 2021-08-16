using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_IExposedPropertyTable : BSWrapperObject < IExposedPropertyTable >

    {
        #region Public

        public BSWrapperObject_UnityEngine_IExposedPropertyTable( IExposedPropertyTable obj ) : base( obj )
        {
            m_Properties["SetReferenceValue"] = new BSFunctionReference(
                new BSFunction(
                    "function SetReferenceValue(id, value)",
                    a =>
                    {
                        m_InternalObject.SetReferenceValue(
                            WrapperHelper.UnwrapObject < PropertyName >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["ClearReferenceValue"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearReferenceValue(id)",
                    a =>
                    {
                        m_InternalObject.ClearReferenceValue( WrapperHelper.UnwrapObject < PropertyName >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

        }

        #endregion
    }

}

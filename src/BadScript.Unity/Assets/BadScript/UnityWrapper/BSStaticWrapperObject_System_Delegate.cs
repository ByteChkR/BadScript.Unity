using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Delegate : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Delegate() : base( typeof( Delegate ) )
        {
            m_StaticProperties["Combine"] = new BSFunctionReference(
                new BSFunction(
                    "function Combine(a, b)",
                    a => new BSWrapperObject_System_Delegate(
                        Delegate.Combine(
                            WrapperHelper.UnwrapObject < Delegate >( a[0] ),
                            WrapperHelper.UnwrapObject < Delegate >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Remove"] = new BSFunctionReference(
                new BSFunction(
                    "function Remove(source, value)",
                    a => new BSWrapperObject_System_Delegate(
                        Delegate.Remove(
                            WrapperHelper.UnwrapObject < Delegate >( a[0] ),
                            WrapperHelper.UnwrapObject < Delegate >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["RemoveAll"] = new BSFunctionReference(
                new BSFunction(
                    "function RemoveAll(source, value)",
                    a => new BSWrapperObject_System_Delegate(
                        Delegate.RemoveAll(
                            WrapperHelper.UnwrapObject < Delegate >( a[0] ),
                            WrapperHelper.UnwrapObject < Delegate >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

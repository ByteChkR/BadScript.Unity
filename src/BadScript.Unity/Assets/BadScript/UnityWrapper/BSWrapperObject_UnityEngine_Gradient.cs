using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Gradient : BSWrapperObject < Gradient >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Gradient( Gradient obj ) : base( obj )
        {
            m_Properties["Evaluate"] = new BSFunctionReference(
                new BSFunction(
                    "function Evaluate(time)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.Evaluate( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(o)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Gradient >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

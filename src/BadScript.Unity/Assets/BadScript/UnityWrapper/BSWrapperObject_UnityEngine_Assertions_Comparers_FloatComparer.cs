using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Assertions.Comparers;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Assertions_Comparers_FloatComparer : BSWrapperObject < FloatComparer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Assertions_Comparers_FloatComparer( FloatComparer obj ) : base( obj )
        {
            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(a, b)",
                    a => m_InternalObject.Equals(
                        WrapperHelper.UnwrapObject < float >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode(obj)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetHashCode( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

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

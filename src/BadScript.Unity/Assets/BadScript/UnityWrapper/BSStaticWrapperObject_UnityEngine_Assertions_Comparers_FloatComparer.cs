using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Assertions.Comparers;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Assertions_Comparers_FloatComparer : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Assertions_Comparers_FloatComparer() : base( typeof( FloatComparer ) )
        {
            m_StaticProperties["s_ComparerWithDefaultTolerance"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Assertions_Comparers_FloatComparer(
                    FloatComparer.s_ComparerWithDefaultTolerance ),
                null );

            m_StaticProperties["kEpsilon"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) FloatComparer.kEpsilon ),
                null );

            m_StaticProperties["AreEqual"] = new BSFunctionReference(
                new BSFunction(
                    "function AreEqual(expected, actual, error)",
                    a => FloatComparer.AreEqual(
                        WrapperHelper.UnwrapObject < float >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["AreEqualRelative"] = new BSFunctionReference(
                new BSFunction(
                    "function AreEqualRelative(expected, actual, error)",
                    a => FloatComparer.AreEqualRelative(
                        WrapperHelper.UnwrapObject < float >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

        }

        #endregion
    }

}

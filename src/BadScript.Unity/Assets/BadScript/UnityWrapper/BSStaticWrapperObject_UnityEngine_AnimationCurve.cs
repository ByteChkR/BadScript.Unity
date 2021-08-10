using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AnimationCurve : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AnimationCurve() : base( typeof( AnimationCurve ) )
        {
            m_StaticProperties["Constant"] = new BSFunctionReference(
                new BSFunction(
                    "function Constant(timeStart, timeEnd, value)",
                    a => new BSWrapperObject_UnityEngine_AnimationCurve(
                        AnimationCurve.Constant(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Linear"] = new BSFunctionReference(
                new BSFunction(
                    "function Linear(timeStart, valueStart, timeEnd, valueEnd)",
                    a => new BSWrapperObject_UnityEngine_AnimationCurve(
                        AnimationCurve.Linear(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["EaseInOut"] = new BSFunctionReference(
                new BSFunction(
                    "function EaseInOut(timeStart, valueStart, timeEnd, valueEnd)",
                    a => new BSWrapperObject_UnityEngine_AnimationCurve(
                        AnimationCurve.EaseInOut(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

        }

        #endregion
    }

}

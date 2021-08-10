using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements.Experimental;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Experimental_Easing : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Experimental_Easing() : base( typeof( Easing ) )
        {
            m_StaticProperties["Step"] = new BSFunctionReference(
                new BSFunction(
                    "function Step(t)",
                    a => new BSObject( ( decimal ) Easing.Step( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Linear"] = new BSFunctionReference(
                new BSFunction(
                    "function Linear(t)",
                    a => new BSObject( ( decimal ) Easing.Linear( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InSine"] = new BSFunctionReference(
                new BSFunction(
                    "function InSine(t)",
                    a => new BSObject( ( decimal ) Easing.InSine( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["OutSine"] = new BSFunctionReference(
                new BSFunction(
                    "function OutSine(t)",
                    a => new BSObject( ( decimal ) Easing.OutSine( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InOutSine"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutSine(t)",
                    a => new BSObject( ( decimal ) Easing.InOutSine( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InQuad"] = new BSFunctionReference(
                new BSFunction(
                    "function InQuad(t)",
                    a => new BSObject( ( decimal ) Easing.InQuad( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["OutQuad"] = new BSFunctionReference(
                new BSFunction(
                    "function OutQuad(t)",
                    a => new BSObject( ( decimal ) Easing.OutQuad( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InOutQuad"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutQuad(t)",
                    a => new BSObject( ( decimal ) Easing.InOutQuad( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InCubic"] = new BSFunctionReference(
                new BSFunction(
                    "function InCubic(t)",
                    a => new BSObject( ( decimal ) Easing.InCubic( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["OutCubic"] = new BSFunctionReference(
                new BSFunction(
                    "function OutCubic(t)",
                    a => new BSObject( ( decimal ) Easing.OutCubic( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InOutCubic"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutCubic(t)",
                    a => new BSObject( ( decimal ) Easing.InOutCubic( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InPower"] = new BSFunctionReference(
                new BSFunction(
                    "function InPower(t, power)",
                    a => new BSObject(
                        ( decimal ) Easing.InPower(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["OutPower"] = new BSFunctionReference(
                new BSFunction(
                    "function OutPower(t, power)",
                    a => new BSObject(
                        ( decimal ) Easing.OutPower(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["InOutPower"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutPower(t, power)",
                    a => new BSObject(
                        ( decimal ) Easing.InOutPower(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["InBounce"] = new BSFunctionReference(
                new BSFunction(
                    "function InBounce(t)",
                    a => new BSObject( ( decimal ) Easing.InBounce( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["OutBounce"] = new BSFunctionReference(
                new BSFunction(
                    "function OutBounce(t)",
                    a => new BSObject( ( decimal ) Easing.OutBounce( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InOutBounce"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutBounce(t)",
                    a => new BSObject( ( decimal ) Easing.InOutBounce( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InElastic"] = new BSFunctionReference(
                new BSFunction(
                    "function InElastic(t)",
                    a => new BSObject( ( decimal ) Easing.InElastic( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["OutElastic"] = new BSFunctionReference(
                new BSFunction(
                    "function OutElastic(t)",
                    a => new BSObject( ( decimal ) Easing.OutElastic( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InOutElastic"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutElastic(t)",
                    a => new BSObject(
                        ( decimal ) Easing.InOutElastic( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InBack"] = new BSFunctionReference(
                new BSFunction(
                    "function InBack(t)",
                    a => new BSObject( ( decimal ) Easing.InBack( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["OutBack"] = new BSFunctionReference(
                new BSFunction(
                    "function OutBack(t)",
                    a => new BSObject( ( decimal ) Easing.OutBack( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InOutBack"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutBack(t)",
                    a => new BSObject( ( decimal ) Easing.InOutBack( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InBack"] = new BSFunctionReference(
                new BSFunction(
                    "function InBack(t, s)",
                    a => new BSObject(
                        ( decimal ) Easing.InBack(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["OutBack"] = new BSFunctionReference(
                new BSFunction(
                    "function OutBack(t, s)",
                    a => new BSObject(
                        ( decimal ) Easing.OutBack(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["InOutBack"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutBack(t, s)",
                    a => new BSObject(
                        ( decimal ) Easing.InOutBack(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["InCirc"] = new BSFunctionReference(
                new BSFunction(
                    "function InCirc(t)",
                    a => new BSObject( ( decimal ) Easing.InCirc( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["OutCirc"] = new BSFunctionReference(
                new BSFunction(
                    "function OutCirc(t)",
                    a => new BSObject( ( decimal ) Easing.OutCirc( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InOutCirc"] = new BSFunctionReference(
                new BSFunction(
                    "function InOutCirc(t)",
                    a => new BSObject( ( decimal ) Easing.InOutCirc( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}

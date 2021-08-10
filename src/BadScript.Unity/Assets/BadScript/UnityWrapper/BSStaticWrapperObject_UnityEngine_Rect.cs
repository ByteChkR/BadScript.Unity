using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rect : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rect() : base( typeof( Rect ) )
        {
            m_StaticProperties["zero"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( Rect.zero ),
                null );

            m_StaticProperties["MinMaxRect"] = new BSFunctionReference(
                new BSFunction(
                    "function MinMaxRect(xmin, ymin, xmax, ymax)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        Rect.MinMaxRect(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["NormalizedToPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function NormalizedToPoint(rectangle, normalizedRectCoordinates)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Rect.NormalizedToPoint(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["PointToNormalized"] = new BSFunctionReference(
                new BSFunction(
                    "function PointToNormalized(rectangle, point)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Rect.PointToNormalized(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

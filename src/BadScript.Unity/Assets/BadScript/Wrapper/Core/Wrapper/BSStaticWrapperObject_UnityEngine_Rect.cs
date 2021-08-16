using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Rect : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Rect() : base(typeof(UnityEngine.Rect))
        {
            m_StaticProperties["zero"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(UnityEngine.Rect.zero), null);
            m_StaticProperties["MinMaxRect"] = new BSFunctionReference(new BSFunction("function MinMaxRect(xmin, ymin, xmax, ymax)", a => new BSWrapperObject_UnityEngine_Rect(UnityEngine.Rect.MinMaxRect(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<System.Single>(a[3]))), 4));
            m_StaticProperties["NormalizedToPoint"] = new BSFunctionReference(new BSFunction("function NormalizedToPoint(rectangle, normalizedRectCoordinates)", a => new BSWrapperObject_UnityEngine_Vector2(UnityEngine.Rect.NormalizedToPoint(WrapperHelper.UnwrapObject<UnityEngine.Rect>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector2>(a[1]))), 2));
            m_StaticProperties["PointToNormalized"] = new BSFunctionReference(new BSFunction("function PointToNormalized(rectangle, point)", a => new BSWrapperObject_UnityEngine_Vector2(UnityEngine.Rect.PointToNormalized(WrapperHelper.UnwrapObject<UnityEngine.Rect>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector2>(a[1]))), 2));

        }
    }

}
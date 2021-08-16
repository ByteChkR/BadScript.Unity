using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Camera : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Camera() : base(typeof(UnityEngine.Camera))
        {
            m_StaticProperties["main"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Camera(UnityEngine.Camera.main), null);
            m_StaticProperties["current"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Camera(UnityEngine.Camera.current), null);
            m_StaticProperties["allCamerasCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Camera.allCamerasCount), null);
            m_StaticProperties["FocalLengthToFieldOfView"] = new BSFunctionReference(new BSFunction("function FocalLengthToFieldOfView(focalLength, sensorSize)", a => new BSObject((decimal)UnityEngine.Camera.FocalLengthToFieldOfView(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]))), 2));
            m_StaticProperties["FieldOfViewToFocalLength"] = new BSFunctionReference(new BSFunction("function FieldOfViewToFocalLength(fieldOfView, sensorSize)", a => new BSObject((decimal)UnityEngine.Camera.FieldOfViewToFocalLength(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]))), 2));
            m_StaticProperties["HorizontalToVerticalFieldOfView"] = new BSFunctionReference(new BSFunction("function HorizontalToVerticalFieldOfView(horizontalFieldOfView, aspectRatio)", a => new BSObject((decimal)UnityEngine.Camera.HorizontalToVerticalFieldOfView(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]))), 2));
            m_StaticProperties["VerticalToHorizontalFieldOfView"] = new BSFunctionReference(new BSFunction("function VerticalToHorizontalFieldOfView(verticalFieldOfView, aspectRatio)", a => new BSObject((decimal)UnityEngine.Camera.VerticalToHorizontalFieldOfView(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]))), 2));
            m_StaticProperties["SetupCurrent"] = new BSFunctionReference(new BSFunction("function SetupCurrent(cur)", a => {
                UnityEngine.Camera.SetupCurrent(WrapperHelper.UnwrapObject<UnityEngine.Camera>(a[0]));
                return new BSObject(null);
            }, 1));

        }
    }

}
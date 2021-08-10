using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Camera : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Camera() : base( typeof( Camera ) )
        {
            m_StaticProperties["main"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Camera( Camera.main ),
                null );

            m_StaticProperties["current"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Camera( Camera.current ),
                null );

            m_StaticProperties["allCamerasCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Camera.allCamerasCount ),
                null );

            m_StaticProperties["FocalLengthToFieldOfView"] = new BSFunctionReference(
                new BSFunction(
                    "function FocalLengthToFieldOfView(focalLength, sensorSize)",
                    a => new BSObject(
                        ( decimal ) Camera.FocalLengthToFieldOfView(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["FieldOfViewToFocalLength"] = new BSFunctionReference(
                new BSFunction(
                    "function FieldOfViewToFocalLength(fieldOfView, sensorSize)",
                    a => new BSObject(
                        ( decimal ) Camera.FieldOfViewToFocalLength(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["HorizontalToVerticalFieldOfView"] = new BSFunctionReference(
                new BSFunction(
                    "function HorizontalToVerticalFieldOfView(horizontalFieldOfView, aspectRatio)",
                    a => new BSObject(
                        ( decimal ) Camera.HorizontalToVerticalFieldOfView(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["VerticalToHorizontalFieldOfView"] = new BSFunctionReference(
                new BSFunction(
                    "function VerticalToHorizontalFieldOfView(verticalFieldOfView, aspectRatio)",
                    a => new BSObject(
                        ( decimal ) Camera.VerticalToHorizontalFieldOfView(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}

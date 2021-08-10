using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_SortingSettings : BSWrapperObject < SortingSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_SortingSettings( SortingSettings obj ) : base( obj )
        {
            m_Properties["worldToCameraMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.worldToCameraMatrix ),
                x => m_InternalObject.worldToCameraMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["cameraPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.cameraPosition ),
                x => m_InternalObject.cameraPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["customAxis"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.customAxis ),
                x => m_InternalObject.customAxis = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < SortingSettings >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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

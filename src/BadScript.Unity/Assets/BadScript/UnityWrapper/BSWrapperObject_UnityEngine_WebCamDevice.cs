using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WebCamDevice : BSWrapperObject < WebCamDevice >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WebCamDevice( WebCamDevice obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.name ), null );

            m_Properties["isFrontFacing"] = new BSReflectionReference(
                () => m_InternalObject.isFrontFacing ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["depthCameraName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.depthCameraName ),
                null );

            m_Properties["isAutoFocusPointSupported"] = new BSReflectionReference(
                () => m_InternalObject.isAutoFocusPointSupported ? BSObject.One : BSObject.Zero,
                null );

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

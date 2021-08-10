using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_LODParameters : BSWrapperObject < LODParameters >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_LODParameters( LODParameters obj ) : base( obj )
        {
            m_Properties["isOrthographic"] = new BSReflectionReference(
                () => m_InternalObject.isOrthographic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isOrthographic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["cameraPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.cameraPosition ),
                x => m_InternalObject.cameraPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["fieldOfView"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fieldOfView ),
                x => m_InternalObject.fieldOfView = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["orthoSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.orthoSize ),
                x => m_InternalObject.orthoSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["cameraPixelHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cameraPixelHeight ),
                x => m_InternalObject.cameraPixelHeight = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < LODParameters >( a[0] ) )
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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_CustomRenderTextureUpdateZone : BSWrapperObject < CustomRenderTextureUpdateZone >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CustomRenderTextureUpdateZone( CustomRenderTextureUpdateZone obj ) : base(
            obj )
        {
            m_Properties["updateZoneCenter"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.updateZoneCenter ),
                x => m_InternalObject.updateZoneCenter = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["updateZoneSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.updateZoneSize ),
                x => m_InternalObject.updateZoneSize = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["passIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.passIndex ),
                x => m_InternalObject.passIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["needSwap"] = new BSReflectionReference(
                () => m_InternalObject.needSwap ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.needSwap = WrapperHelper.UnwrapObject < bool >( x ) );

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

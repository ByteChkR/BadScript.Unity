using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.VFX;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_VFX_VFXParticleSystemInfo : BSWrapperObject < VFXParticleSystemInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_VFX_VFXParticleSystemInfo( VFXParticleSystemInfo obj ) : base( obj )
        {
            m_Properties["aliveCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.aliveCount ),
                x => m_InternalObject.aliveCount = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["capacity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.capacity ),
                x => m_InternalObject.capacity = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["sleeping"] = new BSReflectionReference(
                () => m_InternalObject.sleeping ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.sleeping = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                x => m_InternalObject.bounds = WrapperHelper.UnwrapObject < Bounds >( x ) );

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

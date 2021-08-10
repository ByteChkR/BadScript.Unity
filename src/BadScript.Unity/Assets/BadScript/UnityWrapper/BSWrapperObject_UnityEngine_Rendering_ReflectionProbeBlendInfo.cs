using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Rendering_ReflectionProbeBlendInfo : BSWrapperObject < ReflectionProbeBlendInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_ReflectionProbeBlendInfo( ReflectionProbeBlendInfo obj ) : base(
            obj )
        {
            m_Properties["probe"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ReflectionProbe( m_InternalObject.probe ),
                x => m_InternalObject.probe = WrapperHelper.UnwrapObject < ReflectionProbe >( x ) );

            m_Properties["weight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight ),
                x => m_InternalObject.weight = WrapperHelper.UnwrapObject < float >( x ) );

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

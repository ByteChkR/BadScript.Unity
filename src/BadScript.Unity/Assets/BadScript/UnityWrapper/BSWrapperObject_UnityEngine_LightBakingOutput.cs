using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LightBakingOutput : BSWrapperObject < LightBakingOutput >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LightBakingOutput( LightBakingOutput obj ) : base( obj )
        {
            m_Properties["probeOcclusionLightIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.probeOcclusionLightIndex ),
                x => m_InternalObject.probeOcclusionLightIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["occlusionMaskChannel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.occlusionMaskChannel ),
                x => m_InternalObject.occlusionMaskChannel = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["isBaked"] = new BSReflectionReference(
                () => m_InternalObject.isBaked ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isBaked = WrapperHelper.UnwrapObject < bool >( x ) );

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

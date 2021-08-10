using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_ShadowDrawingSettings : BSWrapperObject < ShadowDrawingSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_ShadowDrawingSettings( ShadowDrawingSettings obj ) : base( obj )
        {
            m_Properties["cullingResults"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_CullingResults( m_InternalObject.cullingResults ),
                x => m_InternalObject.cullingResults = WrapperHelper.UnwrapObject < CullingResults >( x ) );

            m_Properties["lightIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightIndex ),
                x => m_InternalObject.lightIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["useRenderingLayerMaskTest"] = new BSReflectionReference(
                () => m_InternalObject.useRenderingLayerMaskTest ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useRenderingLayerMaskTest = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["splitData"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_ShadowSplitData( m_InternalObject.splitData ),
                x => m_InternalObject.splitData = WrapperHelper.UnwrapObject < ShadowSplitData >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < ShadowDrawingSettings >( a[0] ) )
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

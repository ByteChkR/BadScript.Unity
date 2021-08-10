using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ContactFilter2D : BSWrapperObject < ContactFilter2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ContactFilter2D( ContactFilter2D obj ) : base( obj )
        {
            m_Properties["isFiltering"] = new BSReflectionReference(
                () => m_InternalObject.isFiltering ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["useTriggers"] = new BSReflectionReference(
                () => m_InternalObject.useTriggers ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useTriggers = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useLayerMask"] = new BSReflectionReference(
                () => m_InternalObject.useLayerMask ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useLayerMask = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useDepth"] = new BSReflectionReference(
                () => m_InternalObject.useDepth ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useDepth = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useOutsideDepth"] = new BSReflectionReference(
                () => m_InternalObject.useOutsideDepth ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useOutsideDepth = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useNormalAngle"] = new BSReflectionReference(
                () => m_InternalObject.useNormalAngle ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useNormalAngle = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useOutsideNormalAngle"] = new BSReflectionReference(
                () => m_InternalObject.useOutsideNormalAngle ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useOutsideNormalAngle = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["layerMask"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_LayerMask( m_InternalObject.layerMask ),
                x => m_InternalObject.layerMask = WrapperHelper.UnwrapObject < LayerMask >( x ) );

            m_Properties["minDepth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minDepth ),
                x => m_InternalObject.minDepth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxDepth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxDepth ),
                x => m_InternalObject.maxDepth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["minNormalAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minNormalAngle ),
                x => m_InternalObject.minNormalAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxNormalAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxNormalAngle ),
                x => m_InternalObject.maxNormalAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["IsFilteringTrigger"] = new BSFunctionReference(
                new BSFunction(
                    "function IsFilteringTrigger(collider)",
                    a => m_InternalObject.IsFilteringTrigger( WrapperHelper.UnwrapObject < Collider2D >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsFilteringLayerMask"] = new BSFunctionReference(
                new BSFunction(
                    "function IsFilteringLayerMask(obj)",
                    a => m_InternalObject.IsFilteringLayerMask( WrapperHelper.UnwrapObject < GameObject >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsFilteringDepth"] = new BSFunctionReference(
                new BSFunction(
                    "function IsFilteringDepth(obj)",
                    a => m_InternalObject.IsFilteringDepth( WrapperHelper.UnwrapObject < GameObject >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsFilteringNormalAngle"] = new BSFunctionReference(
                new BSFunction(
                    "function IsFilteringNormalAngle(normal)",
                    a => m_InternalObject.IsFilteringNormalAngle( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsFilteringNormalAngle"] = new BSFunctionReference(
                new BSFunction(
                    "function IsFilteringNormalAngle(angle)",
                    a => m_InternalObject.IsFilteringNormalAngle( WrapperHelper.UnwrapObject < float >( a[0] ) )
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

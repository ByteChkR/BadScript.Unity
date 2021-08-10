using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_DetailPrototype : BSWrapperObject < DetailPrototype >

    {
        #region Public

        public BSWrapperObject_UnityEngine_DetailPrototype( DetailPrototype obj ) : base( obj )
        {
            m_Properties["prototype"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.prototype ),
                x => m_InternalObject.prototype = WrapperHelper.UnwrapObject < GameObject >( x ) );

            m_Properties["prototypeTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.prototypeTexture ),
                x => m_InternalObject.prototypeTexture = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["minWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minWidth ),
                x => m_InternalObject.minWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxWidth ),
                x => m_InternalObject.maxWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["minHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minHeight ),
                x => m_InternalObject.minHeight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxHeight ),
                x => m_InternalObject.maxHeight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["noiseSpread"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.noiseSpread ),
                x => m_InternalObject.noiseSpread = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bendFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bendFactor ),
                x => m_InternalObject.bendFactor = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["holeEdgePadding"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.holeEdgePadding ),
                x => m_InternalObject.holeEdgePadding = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["healthyColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.healthyColor ),
                x => m_InternalObject.healthyColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["dryColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.dryColor ),
                x => m_InternalObject.dryColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["usePrototypeMesh"] = new BSReflectionReference(
                () => m_InternalObject.usePrototypeMesh ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.usePrototypeMesh = WrapperHelper.UnwrapObject < bool >( x ) );

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

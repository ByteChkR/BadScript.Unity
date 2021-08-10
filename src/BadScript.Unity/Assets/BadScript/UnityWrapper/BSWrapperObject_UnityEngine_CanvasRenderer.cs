using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CanvasRenderer : BSWrapperObject < CanvasRenderer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CanvasRenderer( CanvasRenderer obj ) : base( obj )
        {
            m_Properties["hasPopInstruction"] = new BSReflectionReference(
                () => m_InternalObject.hasPopInstruction ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.hasPopInstruction = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["materialCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.materialCount ),
                x => m_InternalObject.materialCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["popMaterialCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.popMaterialCount ),
                x => m_InternalObject.popMaterialCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["absoluteDepth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.absoluteDepth ),
                null );

            m_Properties["hasMoved"] = new BSReflectionReference(
                () => m_InternalObject.hasMoved ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["cullTransparentMesh"] = new BSReflectionReference(
                () => m_InternalObject.cullTransparentMesh ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.cullTransparentMesh = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["hasRectClipping"] = new BSReflectionReference(
                () => m_InternalObject.hasRectClipping ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["relativeDepth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.relativeDepth ),
                null );

            m_Properties["cull"] = new BSReflectionReference(
                () => m_InternalObject.cull ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.cull = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isMask"] = new BSReflectionReference(
                () => m_InternalObject.isMask ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isMask = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["clippingSoftness"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.clippingSoftness ),
                x => m_InternalObject.clippingSoftness = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetMaterial"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMaterial(index)",
                    a => new BSWrapperObject_UnityEngine_Material(
                        m_InternalObject.GetMaterial( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPopMaterial"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPopMaterial(index)",
                    a => new BSWrapperObject_UnityEngine_Material(
                        m_InternalObject.GetPopMaterial( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

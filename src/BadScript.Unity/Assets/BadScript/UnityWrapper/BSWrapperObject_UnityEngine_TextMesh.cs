using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TextMesh : BSWrapperObject < TextMesh >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextMesh( TextMesh obj ) : base( obj )
        {
            m_Properties["text"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.text ),
                x => m_InternalObject.text = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["font"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Font( m_InternalObject.font ),
                x => m_InternalObject.font = WrapperHelper.UnwrapObject < Font >( x ) );

            m_Properties["fontSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fontSize ),
                x => m_InternalObject.fontSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["offsetZ"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.offsetZ ),
                x => m_InternalObject.offsetZ = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["characterSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.characterSize ),
                x => m_InternalObject.characterSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["lineSpacing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lineSpacing ),
                x => m_InternalObject.lineSpacing = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["tabSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tabSize ),
                x => m_InternalObject.tabSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["richText"] = new BSReflectionReference(
                () => m_InternalObject.richText ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.richText = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color >( x ) );

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

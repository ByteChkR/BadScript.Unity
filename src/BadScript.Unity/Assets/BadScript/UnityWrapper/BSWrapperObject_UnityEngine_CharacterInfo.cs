using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CharacterInfo : BSWrapperObject < CharacterInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CharacterInfo( CharacterInfo obj ) : base( obj )
        {
            m_Properties["advance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.advance ),
                x => m_InternalObject.advance = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["glyphWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.glyphWidth ),
                x => m_InternalObject.glyphWidth = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["glyphHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.glyphHeight ),
                x => m_InternalObject.glyphHeight = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["bearing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bearing ),
                x => m_InternalObject.bearing = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["minY"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minY ),
                x => m_InternalObject.minY = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["maxY"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxY ),
                x => m_InternalObject.maxY = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["minX"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minX ),
                x => m_InternalObject.minX = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["maxX"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxX ),
                x => m_InternalObject.maxX = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["uvBottomLeft"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.uvBottomLeft ),
                x => m_InternalObject.uvBottomLeft = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["uvBottomRight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.uvBottomRight ),
                x => m_InternalObject.uvBottomRight = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["uvTopRight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.uvTopRight ),
                x => m_InternalObject.uvTopRight = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["uvTopLeft"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.uvTopLeft ),
                x => m_InternalObject.uvTopLeft = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["index"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.index ),
                x => m_InternalObject.index = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["uv"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.uv ),
                x => m_InternalObject.uv = WrapperHelper.UnwrapObject < Rect >( x ) );

            m_Properties["vert"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.vert ),
                x => m_InternalObject.vert = WrapperHelper.UnwrapObject < Rect >( x ) );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["flipped"] = new BSReflectionReference(
                () => m_InternalObject.flipped ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.flipped = WrapperHelper.UnwrapObject < bool >( x ) );

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

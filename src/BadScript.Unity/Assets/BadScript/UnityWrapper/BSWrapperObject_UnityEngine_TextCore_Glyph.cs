using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TextCore;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TextCore_Glyph : BSWrapperObject < Glyph >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextCore_Glyph( Glyph obj ) : base( obj )
        {
            m_Properties["index"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.index ),
                x => m_InternalObject.index = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["metrics"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TextCore_GlyphMetrics( m_InternalObject.metrics ),
                x => m_InternalObject.metrics = WrapperHelper.UnwrapObject < GlyphMetrics >( x ) );

            m_Properties["glyphRect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TextCore_GlyphRect( m_InternalObject.glyphRect ),
                x => m_InternalObject.glyphRect = WrapperHelper.UnwrapObject < GlyphRect >( x ) );

            m_Properties["scale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scale ),
                x => m_InternalObject.scale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["atlasIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.atlasIndex ),
                x => m_InternalObject.atlasIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(other)",
                    a => m_InternalObject.Compare( WrapperHelper.UnwrapObject < Glyph >( a[0] ) )
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

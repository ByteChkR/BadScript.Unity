using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TextCore;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TextCore_GlyphMetrics : BSWrapperObject < GlyphMetrics >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextCore_GlyphMetrics( GlyphMetrics obj ) : base( obj )
        {
            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["horizontalBearingX"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.horizontalBearingX ),
                x => m_InternalObject.horizontalBearingX = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["horizontalBearingY"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.horizontalBearingY ),
                x => m_InternalObject.horizontalBearingY = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["horizontalAdvance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.horizontalAdvance ),
                x => m_InternalObject.horizontalAdvance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < GlyphMetrics >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

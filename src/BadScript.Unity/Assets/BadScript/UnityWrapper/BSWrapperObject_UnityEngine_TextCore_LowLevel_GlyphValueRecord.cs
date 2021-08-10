using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TextCore.LowLevel;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphValueRecord : BSWrapperObject < GlyphValueRecord >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphValueRecord( GlyphValueRecord obj ) : base( obj )
        {
            m_Properties["xPlacement"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.xPlacement ),
                x => m_InternalObject.xPlacement = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["yPlacement"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.yPlacement ),
                x => m_InternalObject.yPlacement = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["xAdvance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.xAdvance ),
                x => m_InternalObject.xAdvance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["yAdvance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.yAdvance ),
                x => m_InternalObject.yAdvance = WrapperHelper.UnwrapObject < float >( x ) );

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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < GlyphValueRecord >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

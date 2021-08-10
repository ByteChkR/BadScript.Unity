using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TextCore.LowLevel;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphAdjustmentRecord : BSWrapperObject < GlyphAdjustmentRecord >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphAdjustmentRecord( GlyphAdjustmentRecord obj ) : base(
            obj )
        {
            m_Properties["glyphIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.glyphIndex ),
                x => m_InternalObject.glyphIndex = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["glyphValueRecord"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphValueRecord(
                    m_InternalObject.glyphValueRecord ),
                x => m_InternalObject.glyphValueRecord = WrapperHelper.UnwrapObject < GlyphValueRecord >( x ) );

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

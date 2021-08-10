using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TextCore.LowLevel;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphPairAdjustmentRecord : BSWrapperObject <
            GlyphPairAdjustmentRecord >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphPairAdjustmentRecord( GlyphPairAdjustmentRecord obj )
            : base( obj )
        {
            m_Properties["firstAdjustmentRecord"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphAdjustmentRecord(
                    m_InternalObject.firstAdjustmentRecord ),
                x => m_InternalObject.firstAdjustmentRecord =
                    WrapperHelper.UnwrapObject < GlyphAdjustmentRecord >( x ) );

            m_Properties["secondAdjustmentRecord"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphAdjustmentRecord(
                    m_InternalObject.secondAdjustmentRecord ),
                x => m_InternalObject.secondAdjustmentRecord =
                    WrapperHelper.UnwrapObject < GlyphAdjustmentRecord >( x ) );

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

using System.Text;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Text_DecoderFallback : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Text_DecoderFallback() : base( typeof( DecoderFallback ) )
        {
            m_StaticProperties["ReplacementFallback"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_DecoderFallback( DecoderFallback.ReplacementFallback ),
                null );

            m_StaticProperties["ExceptionFallback"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_DecoderFallback( DecoderFallback.ExceptionFallback ),
                null );

        }

        #endregion
    }

}

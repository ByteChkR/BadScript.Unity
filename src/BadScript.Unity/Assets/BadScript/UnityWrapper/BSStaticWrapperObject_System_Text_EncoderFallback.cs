using System.Text;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Text_EncoderFallback : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Text_EncoderFallback() : base( typeof( EncoderFallback ) )
        {
            m_StaticProperties["ReplacementFallback"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_EncoderFallback( EncoderFallback.ReplacementFallback ),
                null );

            m_StaticProperties["ExceptionFallback"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_EncoderFallback( EncoderFallback.ExceptionFallback ),
                null );

        }

        #endregion
    }

}

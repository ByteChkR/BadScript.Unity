using System.Text;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Text_EncoderFallback : BSWrapperObject < EncoderFallback >

    {
        #region Public

        public BSWrapperObject_System_Text_EncoderFallback( EncoderFallback obj ) : base( obj )
        {
            m_Properties["MaxCharCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxCharCount ),
                null );

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

using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows.Speech;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Windows_Speech_SemanticMeaning : BSWrapperObject < SemanticMeaning >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Windows_Speech_SemanticMeaning( SemanticMeaning obj ) : base( obj )
        {
            m_Properties["key"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.key ),
                x => m_InternalObject.key = WrapperHelper.UnwrapObject < string >( x ) );

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

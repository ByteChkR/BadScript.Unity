using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Playables;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Playables_PlayableOutput : BSWrapperObject < PlayableOutput >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_PlayableOutput( PlayableOutput obj ) : base( obj )
        {
            m_Properties["GetHandle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHandle()",
                    a => new BSWrapperObject_UnityEngine_Playables_PlayableOutputHandle( m_InternalObject.GetHandle() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < PlayableOutput >( a[0] ) )
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

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}

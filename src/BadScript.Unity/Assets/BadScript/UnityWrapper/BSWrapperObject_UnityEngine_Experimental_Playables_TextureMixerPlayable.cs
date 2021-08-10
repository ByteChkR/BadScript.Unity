using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Experimental.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Experimental_Playables_TextureMixerPlayable : BSWrapperObject < TextureMixerPlayable
        >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_Playables_TextureMixerPlayable( TextureMixerPlayable obj ) :
            base( obj )
        {
            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < TextureMixerPlayable >( a[0] ) )
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
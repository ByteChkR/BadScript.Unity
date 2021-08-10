using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Playables_PlayableAsset : BSWrapperObject < PlayableAsset >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_PlayableAsset( PlayableAsset obj ) : base( obj )
        {
            m_Properties["duration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.duration ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["CreatePlayable"] = new BSFunctionReference(
                new BSFunction(
                    "function CreatePlayable(graph, owner)",
                    a => new BSWrapperObject_UnityEngine_Playables_Playable(
                        m_InternalObject.CreatePlayable(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < GameObject >( a[1] ) ) ),
                    2 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

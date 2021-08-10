using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Playables_PlayableGraph : BSWrapperObject < PlayableGraph >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_PlayableGraph( PlayableGraph obj ) : base( obj )
        {
            m_Properties["GetRootPlayable"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRootPlayable(index)",
                    a => new BSWrapperObject_UnityEngine_Playables_Playable(
                        m_InternalObject.GetRootPlayable( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetOutput"] = new BSFunctionReference(
                new BSFunction(
                    "function GetOutput(index)",
                    a => new BSWrapperObject_UnityEngine_Playables_PlayableOutput(
                        m_InternalObject.GetOutput( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            //m_Properties["GetOutputByType"] = new BSFunctionReference(new BSFunction("function GetOutputByType(index)", a => new BSWrapperObject_UnityEngine_Playables_PlayableOutput(m_InternalObject.GetOutputByType<UnityEngine.Playables.IPlayableOutput>(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
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

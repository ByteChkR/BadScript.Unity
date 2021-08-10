using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Playables_PlayableBinding : BSWrapperObject < PlayableBinding >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_PlayableBinding( PlayableBinding obj ) : base( obj )
        {
            m_Properties["streamName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.streamName ),
                x => m_InternalObject.streamName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["sourceObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Object( m_InternalObject.sourceObject ),
                x => m_InternalObject.sourceObject = WrapperHelper.UnwrapObject < Object >( x ) );

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

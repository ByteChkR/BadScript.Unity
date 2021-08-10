using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking.Match;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_Match_MatchInfoSnapshot : BSWrapperObject < MatchInfoSnapshot >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_Match_MatchInfoSnapshot( MatchInfoSnapshot obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.name ), null );

            m_Properties["averageEloScore"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.averageEloScore ),
                null );

            m_Properties["maxSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxSize ),
                null );

            m_Properties["currentSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.currentSize ),
                null );

            m_Properties["isPrivate"] = new BSReflectionReference(
                () => m_InternalObject.isPrivate ? BSObject.One : BSObject.Zero,
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

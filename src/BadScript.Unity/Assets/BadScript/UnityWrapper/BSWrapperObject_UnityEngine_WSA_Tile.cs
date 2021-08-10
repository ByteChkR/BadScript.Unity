using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WSA_Tile : BSWrapperObject < Tile >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WSA_Tile( Tile obj ) : base( obj )
        {
            m_Properties["id"] = new BSReflectionReference( () => new BSObject( m_InternalObject.id ), null );

            m_Properties["hasUserConsent"] = new BSReflectionReference(
                () => m_InternalObject.hasUserConsent ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["exists"] = new BSReflectionReference(
                () => m_InternalObject.exists ? BSObject.One : BSObject.Zero,
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

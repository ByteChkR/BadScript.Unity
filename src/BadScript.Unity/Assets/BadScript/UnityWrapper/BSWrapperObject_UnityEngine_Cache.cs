using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Cache : BSWrapperObject < Cache >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Cache( Cache obj ) : base( obj )
        {
            m_Properties["valid"] = new BSReflectionReference(
                () => m_InternalObject.valid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ready"] = new BSReflectionReference(
                () => m_InternalObject.ready ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["readOnly"] = new BSReflectionReference(
                () => m_InternalObject.readOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["path"] = new BSReflectionReference( () => new BSObject( m_InternalObject.path ), null );

            m_Properties["index"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.index ),
                null );

            m_Properties["spaceFree"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spaceFree ),
                null );

            m_Properties["maximumAvailableStorageSpace"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maximumAvailableStorageSpace ),
                x => m_InternalObject.maximumAvailableStorageSpace = WrapperHelper.UnwrapObject < long >( x ) );

            m_Properties["spaceOccupied"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spaceOccupied ),
                null );

            m_Properties["expirationDelay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.expirationDelay ),
                x => m_InternalObject.expirationDelay = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Cache >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ClearCache"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearCache(expiration)",
                    a => m_InternalObject.ClearCache( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}

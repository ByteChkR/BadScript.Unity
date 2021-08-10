using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LocationService : BSWrapperObject < LocationService >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LocationService( LocationService obj ) : base( obj )
        {
            m_Properties["isEnabledByUser"] = new BSReflectionReference(
                () => m_InternalObject.isEnabledByUser ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["lastData"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_LocationInfo( m_InternalObject.lastData ),
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

using System.Runtime.Serialization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Runtime_Serialization_StreamingContext : BSWrapperObject < StreamingContext >

    {
        #region Public

        public BSWrapperObject_System_Runtime_Serialization_StreamingContext( StreamingContext obj ) : base( obj )
        {
            m_Properties["Context"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Context ),
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
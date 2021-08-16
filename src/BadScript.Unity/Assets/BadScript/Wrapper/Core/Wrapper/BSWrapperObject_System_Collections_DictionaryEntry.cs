using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_DictionaryEntry : BSWrapperObject < DictionaryEntry >

    {
        #region Public

        public BSWrapperObject_System_Collections_DictionaryEntry( DictionaryEntry obj ) : base( obj )
        {
            m_Properties["Key"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Key ),
                x => m_InternalObject.Key = WrapperHelper.UnwrapObject < object >( x ) );

            m_Properties["Value"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Value ),
                x => m_InternalObject.Value = WrapperHelper.UnwrapObject < object >( x ) );

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

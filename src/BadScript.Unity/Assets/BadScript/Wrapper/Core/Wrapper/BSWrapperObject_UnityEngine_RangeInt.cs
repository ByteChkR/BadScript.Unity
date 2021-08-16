using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_RangeInt : BSWrapperObject < RangeInt >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RangeInt( RangeInt obj ) : base( obj )
        {
            m_Properties["end"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.end ),
                null );

            m_Properties["start"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.start ),
                x => m_InternalObject.start = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
                x => m_InternalObject.length = WrapperHelper.UnwrapObject < int >( x ) );

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

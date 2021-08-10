using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TestTools;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TestTools_CoveredSequencePoint : BSWrapperObject < CoveredSequencePoint >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TestTools_CoveredSequencePoint( CoveredSequencePoint obj ) : base( obj )
        {
            m_Properties["method"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_MethodBase( m_InternalObject.method ),
                x => m_InternalObject.method = WrapperHelper.UnwrapObject < MethodBase >( x ) );

            m_Properties["ilOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ilOffset ),
                x => m_InternalObject.ilOffset = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["hitCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.hitCount ),
                x => m_InternalObject.hitCount = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["filename"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.filename ),
                x => m_InternalObject.filename = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["line"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.line ),
                x => m_InternalObject.line = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["column"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.column ),
                x => m_InternalObject.column = WrapperHelper.UnwrapObject < uint >( x ) );

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

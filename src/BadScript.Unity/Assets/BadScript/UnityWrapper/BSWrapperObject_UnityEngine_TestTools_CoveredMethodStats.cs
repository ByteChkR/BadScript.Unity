using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TestTools;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TestTools_CoveredMethodStats : BSWrapperObject < CoveredMethodStats >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TestTools_CoveredMethodStats( CoveredMethodStats obj ) : base( obj )
        {
            m_Properties["method"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_MethodBase( m_InternalObject.method ),
                x => m_InternalObject.method = WrapperHelper.UnwrapObject < MethodBase >( x ) );

            m_Properties["totalSequencePoints"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.totalSequencePoints ),
                x => m_InternalObject.totalSequencePoints = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["uncoveredSequencePoints"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.uncoveredSequencePoints ),
                x => m_InternalObject.uncoveredSequencePoints = WrapperHelper.UnwrapObject < int >( x ) );

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
